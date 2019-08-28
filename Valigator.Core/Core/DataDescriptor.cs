using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataDescriptor : IEquatable<DataDescriptor>
	{
		public Type SourceType { get; }

		public Type PropertyType { get; }

		public IStateDescriptor StateDescriptor { get; }

		public IReadOnlyList<IValueDescriptor> ValueDescriptors { get; }

		public DataDescriptor(Type sourceType, Type propertyType, IStateDescriptor stateDescriptor, IValueDescriptor[] valueDescriptors)
		{
			SourceType = sourceType ?? throw new ArgumentNullException(nameof(sourceType));
			PropertyType = propertyType ?? throw new ArgumentNullException(nameof(propertyType));
			StateDescriptor = stateDescriptor ?? throw new ArgumentNullException(nameof(stateDescriptor));
			ValueDescriptors = valueDescriptors ?? throw new ArgumentNullException(nameof(valueDescriptors));
		}

		public override bool Equals(object obj)
			=> obj is DataDescriptor descriptor && Equals(descriptor);

		public bool Equals(DataDescriptor other)
			=> EqualityComparer<Type>.Default.Equals(PropertyType, other.PropertyType) && EqualityComparer<IStateDescriptor>.Default.Equals(StateDescriptor, other.StateDescriptor) && ValueDescriptors.SequenceEqual(other.ValueDescriptors);

		public override int GetHashCode()
		{
			var hashCode = 1881245575;
			hashCode = hashCode * -1521134295 + EqualityComparer<Type>.Default.GetHashCode(PropertyType);
			hashCode = hashCode * -1521134295 + EqualityComparer<IStateDescriptor>.Default.GetHashCode(StateDescriptor);
			return ValueDescriptors.Aggregate(hashCode, (current, descriptor) => current * -1521134295 + EqualityComparer<IValueDescriptor>.Default.GetHashCode(descriptor));
		}

		public static DataDescriptor Create<TDataValue, TValidateValue, TValue>(ICollectionStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> new DataDescriptor(typeof(TValue[]), typeof(TValue[]), stateValidator.GetDescriptor(), valueDescriptors.Where(v => !(v is DummyValidator<TValidateValue>)).Select(v => v.GetDescriptor()).ToArray());

		public static DataDescriptor Create<TDataValue, TValidateValue, TValue>(IStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> new DataDescriptor(typeof(TValue), typeof(TValue), stateValidator.GetDescriptor(), valueDescriptors.Where(v => !(v is DummyValidator<TValidateValue>)).Select(v => v.GetDescriptor()).ToArray());

		public static DataDescriptor Create<TDataValue, TValidateValue, TSource, TValue>(Mapping<TSource, TValue> _, ICollectionStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> new DataDescriptor(typeof(TSource[]), typeof(TValue[]), stateValidator.GetDescriptor(), valueDescriptors.Where(v => !(v is DummyValidator<TValidateValue>)).Select(v => v.GetDescriptor()).ToArray());

		public static DataDescriptor Create<TDataValue, TValidateValue, TSource, TValue>(Mapping<TSource, TValue> _, IStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> new DataDescriptor(typeof(TSource), typeof(TValue), stateValidator.GetDescriptor(), valueDescriptors.Where(v => !(v is DummyValidator<TValidateValue>)).Select(v => v.GetDescriptor()).ToArray());
	}
}
