using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataDescriptor : IEquatable<DataDescriptor>
	{
		public Type PropertyType { get; }

		public IStateDescriptor StateDescriptor { get; }

		public IReadOnlyList<IValueDescriptor> ValueDescriptors { get; }

		public Option<MappedFromDescriptor> MappingDescriptor { get; }

		public DataDescriptor(Type propertyType, IStateDescriptor stateDescriptor, IValueDescriptor[] valueDescriptors, Option<MappedFromDescriptor> mappingDescriptor)
		{
			PropertyType = propertyType ?? throw new ArgumentNullException(nameof(propertyType));
			StateDescriptor = stateDescriptor ?? throw new ArgumentNullException(nameof(stateDescriptor));
			ValueDescriptors = valueDescriptors ?? throw new ArgumentNullException(nameof(valueDescriptors));
			MappingDescriptor = mappingDescriptor;
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

			for (int i = 0; i < ValueDescriptors.Count; ++i)
				hashCode = hashCode * -1521134295 + EqualityComparer<IValueDescriptor>.Default.GetHashCode(ValueDescriptors[i]);

			return hashCode;
		}

		public static DataDescriptor Create<TDataValue, TValidateValue, TSource, TValue>(Mapping<TSource, TValue> mapping, ICollectionStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> new DataDescriptor(typeof(TValue[]), stateValidator.GetDescriptor(), CombineValueDescriptors(stateValidator, valueDescriptors), Option.Create(typeof(TSource) != typeof(TValue), mapping.MappingDescriptor));

		public static DataDescriptor Create<TDataValue, TValidateValue, TSource, TValue>(Mapping<TSource, TValue> mapping, IStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> new DataDescriptor(typeof(TValue), stateValidator.GetDescriptor(), CombineValueDescriptors(stateValidator, valueDescriptors), Option.Create(typeof(TSource) != typeof(TValue), mapping.MappingDescriptor));

		private static IValueDescriptor[] CombineValueDescriptors<TDataValue, TValidateValue, TValue>(IStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> GetValueDescriptors(stateValidator, valueDescriptors).Distinct().ToArray();

		private static IEnumerable<IValueDescriptor> GetValueDescriptors<TDataValue, TValidateValue, TValue>(IStateValidator<TDataValue, TValue> stateValidator, params IValueValidator<TValidateValue>[] valueDescriptors)
			=> valueDescriptors
				.Where(v => !(v is DummyValidator<TValidateValue>))
				.Select(v => v.GetDescriptor())
				.Concat(stateValidator.GetImplicitValueDescriptors());
	}
}
