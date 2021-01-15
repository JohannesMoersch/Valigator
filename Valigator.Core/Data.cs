using System;
using System.Collections;
using System.Collections.Generic;
using Functional;
using Valigator.Core;
using Valigator.Core.DataContainers;
using Valigator.Core.Helpers;

namespace Valigator
{
	public struct Data<TValue>
	{
		private readonly TValue _value;

		private readonly IDataContainer<TValue> _dataContainer;

		public IDataContainer DataContainer
			=> State != DataState.Uninitialized ? _dataContainer : throw new DataNotInitializedException();

		public DataState State { get; }

		public TValue Value
		{
			get
			{
				if (State == DataState.Uninitialized)
					throw new DataNotInitializedException();

				if (State == DataState.UnSet || State == DataState.Set)
					throw new DataNotVerifiedException();

				if (State == DataState.Invalid)
					throw new DataFailedVerificationException();

				return _value;
			}
		}

		public DataDescriptor DataDescriptor
			=> State != DataState.Uninitialized ? _dataContainer.DataDescriptor : throw new DataNotInitializedException();

		internal Data(IDataContainer<TValue> dataContainer)
		{
			State = DataState.UnSet;
			_dataContainer = dataContainer ?? throw new ArgumentNullException(nameof(dataContainer));
			_value = default;
		}

		private Data(DataState state, TValue value, IDataContainer<TValue> dataContainer)
		{
			State = state;
			_dataContainer = dataContainer;
			_value = value;
		}

		internal Data<TValue> WithValidatedValue(TValue value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			if (State == DataState.UnSet)
				return new Data<TValue>(DataState.Set, value, _dataContainer);

			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			throw new DataAlreadySetException();
		}

		public Data<TValue> WithErrors(params ValidationError[] validationErrors)
		{
			if (State == DataState.UnSet && !(_dataContainer is ErrorDataContainer<TValue>))
				return new Data<TValue>(DataState.UnSet, _value, GetErrorDataContainer(_dataContainer, validationErrors));

			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			throw new DataAlreadySetException();
		}

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (State == DataState.Invalid)
			{
				if (_dataContainer.GetErrors().TryGetValue(out var some))
					return Result.Failure<TValue, ValidationError[]>(some);

				return Result.Failure<TValue, ValidationError[]>(Array.Empty<ValidationError>());
			}

			return Result.Success<TValue, ValidationError[]>(Value);
		}

		public Data<TValue> Verify()
			=> Verify(Option.None<object>());

		public Data<TValue> Verify(object model)
			=> Verify(Option.Some(model ?? throw new ArgumentNullException(nameof(model))));

		private Data<TValue> Verify(Option<object> model)
		{
			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			if (State == DataState.Valid || State == DataState.Invalid)
				throw new DataAlreadyVerifiedException();

			if (_dataContainer is ErrorDataContainer<TValue>)
				return new Data<TValue>(DataState.Invalid, _value, _dataContainer);

			if (_dataContainer.IsValid(model, Option.Create(State == DataState.Set, _value)).TryGetValue(out var value, out var failure))
				return new Data<TValue>(DataState.Valid, value, _dataContainer);

			return new Data<TValue>(DataState.Invalid, _value, GetErrorDataContainer(_dataContainer, failure));
		}

		private static IDataContainer<TValue> GetErrorDataContainer(IDataContainer<TValue> dataContainer, ValidationError[] validationErrors)
			=> new ErrorDataContainer<TValue>(() => dataContainer.DataDescriptor, validationErrors);

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;

		public override bool Equals(object obj) 
			=> obj is Data<TValue> data
		 && _dataContainer.DataDescriptor.Equals(data.DataDescriptor)
					&& (_value.Equals(data._value)
						|| (IsEnumerable<TValue>() && IsSequenceEqual(_value as IEnumerable, data._value as IEnumerable)));

		public static bool operator ==(Data<TValue> x, Data<TValue> y)
			=> x.Equals(y);


		private static bool IsSequenceEqual(IEnumerable a, IEnumerable b)
		{
			if (a == null || b == null)
				return false;

			var e1 = a.GetEnumerator();
			var e2 = b.GetEnumerator();
			bool e1Val = e1.MoveNext();
			bool e2Val = e2.MoveNext();
			while (e1Val && e2Val)
			{
				if (!CheckEquality(e1.Current, e2.Current)) return false;
				e1Val = e1.MoveNext();
				e2Val = e2.MoveNext();
			}
			return e1Val == e2Val;
		}


		private static bool CheckEquality(object a, object b)
		=> a is IEnumerable<object> aEnumerable && b is IEnumerable<object> bEnumerable && !(a is string) ?
			IsSequenceEqual(aEnumerable, bEnumerable) :
			Equals(a, b);

		private static bool IsEnumerable<T>()
			=> typeof(T).GetInterface(nameof(IEnumerable)) != null;

		private static bool IsEnumerable(object a)
			=> a.GetType().GetInterface(nameof(IEnumerable)) != null;

		public static bool operator !=(Data<TValue> x, Data<TValue> y)
			=> !(x==y);

		public override int GetHashCode()
		{
			int hashCode = 943777100;
			if (IsEnumerable<TValue>())
			{
				foreach (var item in _value as IEnumerable)
				{
					hashCode = hashCode * -1521134295 + item.GetHashCode();
				}
			}
			else
				hashCode = hashCode * -1521134295 + EqualityComparer<TValue>.Default.GetHashCode(_value);

			hashCode = hashCode * -1521134295 + State.GetHashCode();
			hashCode = hashCode * -1521134295 + DataDescriptor.GetHashCode();
			return hashCode;
		}
	}
}
