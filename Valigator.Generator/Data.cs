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

		public static ValidatorDefinition[] Validators { get; }
			= new[]
			{
				new ValidatorDefinition(ValidatorGroups.Custom, $"CustomValidator<{ValueReplacementString}>", ValueType.Value, Option.None<string>()),
				new ValidatorDefinition(ValidatorGroups.Precision, "PrecisionValidator", ValueType.Value, Option.Some("decimal")),
				new ValidatorDefinition(ValidatorGroups.Equals, $"EqualsValidator<{ValueReplacementString}>", ValueType.Value, Option.None<string>()),
				new ValidatorDefinition(ValidatorGroups.InSet, $"InSetValidator<{ValueReplacementString}>", ValueType.Value, Option.None<string>()),
				new ValidatorDefinition(ValidatorGroups.StringLength, "StringLengthValidator", ValueType.Value, Option.Some("string")),
				new ValidatorDefinition(ValidatorGroups.ItemCount, $"ItemCountValidator<{ValueReplacementString}>", ValueType.Array, Option.None<string>()),
				new ValidatorDefinition(ValidatorGroups.Unique, $"UniqueValidator<{ValueReplacementString}>", ValueType.Array, Option.None<string>())
			}
			.Concat(CreateRangeValidators())
			.ToArray();

		private static IEnumerable<ValidatorDefinition> CreateRangeValidators()
			=> new[]
				{
					("Byte", "byte"),
					("SByte", "sbyte"),
					("Int16", "short"),
					("UInt16", "ushort"),
					("Int32", "int"),
					("UInt32", "uint"),
					("Int64", "long"),
					("UInt64", "ulong"),
					("Single", "float"),
					("Double", "double"),
					("Decimal", "decimal"),
					("DateTime", "DateTime")
				}
				.Select(type => new ValidatorDefinition(ValidatorGroups.Range, $"RangeValidator_{type.Item1}", ValueType.Value, Option.Some(type.Item2)));

		public static ExtensionDefinition[] Extensions { get; }
			= new[]
			{
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Custom), "Assert", new[] { new ParameterDefinition("string", "description"), new ParameterDefinition($"Func<{ValueReplacementString}, bool>", "validator") }, false),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Precision), "Precision", new[] { new ParameterDefinition($"decimal?", "minimumDecimalPlaces", Option.Some("null")), new ParameterDefinition($"decimal?", "maximumDecimalPlaces", Option.Some("null")) }, false, "decimal"),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Equals), "EqualTo", new[] { new ParameterDefinition($"{ValueReplacementString}", "value") }, false),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.InSet), "InSet", new[] { new ParameterDefinition($"params {ValueReplacementString}[]", "options", Option.None<string>()) }, false),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.InSet), "InSet", new[] { new ParameterDefinition($"ISet<{ValueReplacementString}>", "options", Option.None<string>()) }, false),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.StringLength), "Length", new[] { new ParameterDefinition($"int?", "minimumLength", Option.Some("null")), new ParameterDefinition($"int?", "maximumLength", Option.Some("null")) }, false, "string"),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Equals), "NotEmpty", new[] { new ParameterDefinition("String.Empty") }, true, "string"),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Equals), "NotEmpty", new[] { new ParameterDefinition("Guid.Empty") }, true, "Guid"),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.ItemCount), "ItemCount", new[] { new ParameterDefinition($"int?", "minimumItems", Option.Some("null")), new ParameterDefinition($"int?", "maximumItems", Option.Some("null")) }, false),
				new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Unique), "Unique", Array.Empty<ParameterDefinition>(), false)
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
					(type.Item3 ? new[] { new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Equals), "NotZero", new[] { new ParameterDefinition("0") }, true, type.Item2) } : Array.Empty<ExtensionDefinition>())
					.Concat(new[]
						{
							new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Range && v.DataType.ValueOrDefault() == type.Item2), "GreaterThan", new[] { new ParameterDefinition(type.Item2, "value"), new ParameterDefinition("null"), new ParameterDefinition("null"), new ParameterDefinition("null") }, false, type.Item2),
							new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Range && v.DataType.ValueOrDefault() == type.Item2), "GreaterThanOrEqualTo", new[] { new ParameterDefinition("null"), new ParameterDefinition(type.Item2, "value"), new ParameterDefinition("null"), new ParameterDefinition("null") }, false, type.Item2),
							new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Range && v.DataType.ValueOrDefault() == type.Item2), "LessThan", new[] { new ParameterDefinition("null"), new ParameterDefinition("null"), new ParameterDefinition(type.Item2, "value"), new ParameterDefinition("null") }, false, type.Item2),
							new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Range && v.DataType.ValueOrDefault() == type.Item2), "LessThanOrEqualTo",new[] { new ParameterDefinition("null"), new ParameterDefinition("null"), new ParameterDefinition("null"), new ParameterDefinition(type.Item2, "value") }, false, type.Item2),
							new ExtensionDefinition(Validators.First(v => v.Identifier == ValidatorGroups.Range && v.DataType.ValueOrDefault() == type.Item2), "InRange", new[] { new ParameterDefinition($"{type.Item2}?", "greaterThan", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "greaterThanOrEqualTo", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "lessThan", Option.Some("null")), new ParameterDefinition($"{type.Item2}?", "lessThanOrEqualTo", Option.Some("null")) }, false, type.Item2)
						}
					)
				);

		public static IEnumerable<ValidatorGroups[]> ValueValidationPaths { get; }
			= new[]
			{
				new[] { ValidatorGroups.Custom },
				new[] { ValidatorGroups.Equals, ValidatorGroups.Custom },
				new[] { ValidatorGroups.InSet, ValidatorGroups.Custom },
				new[] { ValidatorGroups.Precision, ValidatorGroups.Custom },
				new[] { ValidatorGroups.Precision, ValidatorGroups.Range, ValidatorGroups.Custom },
				new[] { ValidatorGroups.Range, ValidatorGroups.Custom },
				new[] { ValidatorGroups.Range, ValidatorGroups.Precision, ValidatorGroups.Custom },
				new[] { ValidatorGroups.StringLength, ValidatorGroups.Custom }
			};

		public static IEnumerable<ValidatorGroups[]> ArrayValidationPaths { get; }
			= new[]
			{
				new[] { ValidatorGroups.Custom },
				new[] { ValidatorGroups.Unique, ValidatorGroups.Custom },
				new[] { ValidatorGroups.Unique, ValidatorGroups.ItemCount, ValidatorGroups.Custom },
				new[] { ValidatorGroups.ItemCount, ValidatorGroups.Custom },
				new[] { ValidatorGroups.ItemCount, ValidatorGroups.Unique, ValidatorGroups.Custom }
			};
	}
}
