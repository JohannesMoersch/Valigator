using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.StateValidators;

namespace Valigator.Generator
{
	public static class Data
	{
		public static string ValueReplacementString { get; } = "__TValue__";

		public static SourceDefinition[] Sources { get; }
			= new[]
			{
				SourceDefinition.Create(typeof(DefaultedCollectionNullableStateValidator<>)),
				SourceDefinition.Create(typeof(DefaultedCollectionStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalCollectionNullableStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalCollectionStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredCollectionNullableStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredCollectionStateValidator<>)),
				SourceDefinition.Create(typeof(DefaultedNullableStateValidator<>)),
				SourceDefinition.Create(typeof(DefaultedStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalNullableStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredNullableStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredStateValidator<>))
			};

		public static ExtensionDefinition[] Extensions { get; }
			= new[]
			{
				new ExtensionDefinition(ValueValidators.Custom, "Assert", $"CustomValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition("string", "description"), new ParameterDefinition($"Func<{ValueReplacementString}, bool>", "validator") }, $"new CustomValidator<{ValueReplacementString}>(description, validator)", ValueType.Value),
				new ExtensionDefinition(ValueValidators.Precision, "Precision", $"PrecisionValidator", Array.Empty<string>(), new[] { new ParameterDefinition($"decimal?", "minimumDecimalPlaces", Option.Some("null")), new ParameterDefinition($"decimal?", "maximumDecimalPlaces", Option.Some("null")) }, $"new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces)", ValueType.Value, "decimal"),
				new ExtensionDefinition(ValueValidators.Equals, "Equals", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"{ValueReplacementString}", "value") }, $"new EqualsValidator<{ValueReplacementString}>(value)", ValueType.Value),
				new ExtensionDefinition(ValueValidators.InSet, "InSet", $"InSetValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"params {ValueReplacementString}[]", "options", Option.None<string>()) }, $"new InSetValidator<{ValueReplacementString}>(options)", ValueType.Value),
				new ExtensionDefinition(ValueValidators.InSet, "InSet", $"InSetValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"ISet<{ValueReplacementString}>", "options", Option.None<string>()) }, $"new InSetValidator<{ValueReplacementString}>(options)", ValueType.Value),
				new ExtensionDefinition(ValueValidators.StringLength, "Length", $"StringLengthValidator", Array.Empty<string>(), new[] { new ParameterDefinition($"int?", "minimumDecimalPlaces", Option.Some("null")), new ParameterDefinition($"int?", "maximumDecimalPlaces", Option.Some("null")) }, $"new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces)", ValueType.Value, "string"),
				new ExtensionDefinition(ValueValidators.Equals, "NotEmpty", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), Array.Empty<ParameterDefinition>(), $"new EqualsValidator<{ValueReplacementString}>(String.Empty)", ValueType.Value, "string"),
				new ExtensionDefinition(ValueValidators.Equals, "NotEmpty", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), Array.Empty<ParameterDefinition>(), $"new EqualsValidator<{ValueReplacementString}>(Guid.Empty)", ValueType.Value, "Guid")
			}
			.Concat(CreateRangeExtensions())
			.ToArray();

		private static IEnumerable<ExtensionDefinition> CreateRangeExtensions()
			=> new[]
				{
					("Byte", "byte", true),
					("SByte", "sbyte", true),
					("Int16", "short", true),
					("UInt16", "ushort", true),
					("Int32", "int", true),
					("UInt32", "uint", true),
					("Int64", "long", true),
					("UInt64", "ulong", true),
					("Single", "float", true),
					("Double", "double", true),
					("Decimal", "decimal", true),
					("DateTime", "DateTime", false)
				}
				.SelectMany(type =>
					(type.Item3 ? new[] { new ExtensionDefinition(ValueValidators.Equals, "NotZero", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), Array.Empty<ParameterDefinition>(), $"new EqualsValidator<{ValueReplacementString}>(0)", ValueType.Value, type.Item2) } : Array.Empty<ExtensionDefinition>())
					.Concat(new[]
						{
							new ExtensionDefinition(ValueValidators.Range, "LessThan", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(value, null, null, null)", ValueType.Value, type.Item2),
							new ExtensionDefinition(ValueValidators.Range, "LessThanOrEqualTo", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(null, value, null, null)", ValueType.Value, type.Item2),
							new ExtensionDefinition(ValueValidators.Range, "GreaterThan", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(null, null, value, null)", ValueType.Value, type.Item2),
							new ExtensionDefinition(ValueValidators.Range, "GreaterThanOrEqualTo", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(null, null, null, value)", ValueType.Value, type.Item2),
							new ExtensionDefinition(ValueValidators.Range, "InRange", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition($"{type.Item2}?", "lessThan", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "lessThanOrEqualTo", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "greaterThan", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "greaterThanOrEqualTo", Option.Some("null")) }, $"new RangeValidator_{type.Item1}(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo)", ValueType.Value, type.Item2)
						}
						.Take(0)
					)
				);

		public static IEnumerable<ValueValidators[]> ValueValidationPaths { get; }
			= new[]
			{
				new[] { ValueValidators.Custom },
				new[] { ValueValidators.Equals, ValueValidators.Custom },
				new[] { ValueValidators.InSet, ValueValidators.Custom },
				new[] { ValueValidators.Precision, ValueValidators.Custom },
				new[] { ValueValidators.Precision, ValueValidators.Range, ValueValidators.Custom },
				new[] { ValueValidators.Range, ValueValidators.Custom },
				new[] { ValueValidators.Range, ValueValidators.Precision, ValueValidators.Custom },
				new[] { ValueValidators.StringLength, ValueValidators.Custom }
			};

		public static IEnumerable<ValueValidators[]> ArrayValidationPaths { get; }
			= new[]
			{
				new[] { ValueValidators.Custom },
				new[] { ValueValidators.Unique, ValueValidators.Custom },
				new[] { ValueValidators.Unique, ValueValidators.ItemCount, ValueValidators.Custom },
				new[] { ValueValidators.ItemCount, ValueValidators.Custom },
				new[] { ValueValidators.ItemCount, ValueValidators.Unique, ValueValidators.Custom }
			};
	}
}
