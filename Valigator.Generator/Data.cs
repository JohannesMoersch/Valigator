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

		public static SourceDefinition[] Sources =>
			new[]
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

		public static ExtensionDefinition[] Extensions
			=> new[]
			{
				new ExtensionDefinition("Assert", $"CustomValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition("string", "description"), new ParameterDefinition($"Func<{ValueReplacementString}, bool>", "validator") }, $"new CustomValidator<{ValueReplacementString}>(description, validator)", ValueType.Value),
				new ExtensionDefinition("Precision", $"PrecisionValidator", Array.Empty<string>(), new[] { new ParameterDefinition($"decimal?", "minimumDecimalPlaces", Option.Some("null")), new ParameterDefinition($"decimal?", "maximumDecimalPlaces", Option.Some("null")) }, $"new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces)", ValueType.Value, "decimal"),
				new ExtensionDefinition("Equals", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"{ValueReplacementString}", "value") }, $"new EqualsValidator<{ValueReplacementString}>(value)", ValueType.Value),
				new ExtensionDefinition("InSet", $"InSetValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"params {ValueReplacementString}[]", "options", Option.None<string>()) }, $"new InSetValidator<{ValueReplacementString}>(options)", ValueType.Value),
				new ExtensionDefinition("InSet", $"InSetValidator<{ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"ISet<{ValueReplacementString}>", "options", Option.None<string>()) }, $"new InSetValidator<{ValueReplacementString}>(options)", ValueType.Value),
				new ExtensionDefinition("Length", $"StringLengthValidator", Array.Empty<string>(), new[] { new ParameterDefinition($"int?", "minimumDecimalPlaces", Option.Some("null")), new ParameterDefinition($"int?", "maximumDecimalPlaces", Option.Some("null")) }, $"new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces)", ValueType.Value, "string"),
				new ExtensionDefinition("NotEmpty", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), Array.Empty<ParameterDefinition>(), $"new EqualsValidator<{ValueReplacementString}>(String.Empty)", ValueType.Value, "string"),
				new ExtensionDefinition("NotEmpty", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), Array.Empty<ParameterDefinition>(), $"new EqualsValidator<{ValueReplacementString}>(Guid.Empty)", ValueType.Value, "Guid")
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
					(type.Item3 ? new[] { new ExtensionDefinition("NotZero", $"EqualsValidator<{ValueReplacementString}>", Array.Empty<string>(), Array.Empty<ParameterDefinition>(), $"new EqualsValidator<{ValueReplacementString}>(0)", ValueType.Value, type.Item2) } : Array.Empty<ExtensionDefinition>())
					.Concat(new[]
						{
							new ExtensionDefinition("LessThan", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(value, null, null, null)", ValueType.Value, type.Item2),
							new ExtensionDefinition("LessThanOrEqualTo", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(null, value, null, null)", ValueType.Value, type.Item2),
							new ExtensionDefinition("GreaterThan", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(null, null, value, null)", ValueType.Value, type.Item2),
							new ExtensionDefinition("GreaterThanOrEqualTo", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition(type.Item2, "value") }, $"new RangeValidator_{type.Item1}(null, null, null, value)", ValueType.Value, type.Item2),
							new ExtensionDefinition("InRange", $"RangeValidator_{type.Item1}", Array.Empty<string>(), new[] { new ParameterDefinition($"{type.Item2}?", "lessThan", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "lessThanOrEqualTo", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "greaterThan", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "greaterThanOrEqualTo", Option.Some("null")) }, $"new RangeValidator_{type.Item1}(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo)", ValueType.Value, type.Item2)
						}
					)
				)
			;
	}
}
