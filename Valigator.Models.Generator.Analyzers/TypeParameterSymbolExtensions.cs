using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class TypeParameterSymbolExtensions
	{
		public static bool IsEquivalent(this ITypeParameterSymbol type, ITypeParameterSymbol target)
			=>
			type.HasReferenceTypeConstraint == target.HasReferenceTypeConstraint &&
			type.HasValueTypeConstraint == target.HasValueTypeConstraint &&
			type.HasConstructorConstraint == target.HasConstructorConstraint &&
			type.HasNotNullConstraint == target.HasNotNullConstraint &&
			type.HasUnmanagedTypeConstraint == target.HasUnmanagedTypeConstraint &&
			IsEqual(type.ReferenceTypeConstraintNullableAnnotation, target.ReferenceTypeConstraintNullableAnnotation) &&
			type.ConstraintNullableAnnotations.SequenceEqual(target.ConstraintNullableAnnotations, IsEqual) &&
			type.ConstraintTypes.SequenceEqual(target.ConstraintTypes, IsEqual);

		private static bool IsEqual(NullableAnnotation left, NullableAnnotation right)
			=> left == NullableAnnotation.None || right == NullableAnnotation.None || left == right;

		private static bool IsEqual(ITypeSymbol left, ITypeSymbol right)
		{
			if (left is ITypeParameterSymbol leftParameter && right is ITypeParameterSymbol rightParameter)
				return left.Name == right.Name;
		
			return SymbolEqualityComparer.Default.Equals(left, right);
		}

		public static string ToCSharpGenericParameterCode(this IEnumerable<ITypeParameterSymbol> typeParameters)
		{
			var parameterNames = typeParameters
				.Select(p => p.Name)
				.ToArray();

			return parameterNames.Any() ? $"<{String.Join(", ", parameterNames)}>" : String.Empty;
		}

		public static IEnumerable<string> ToCSharpGenericParameterConstraintsCode(this IEnumerable<ITypeParameterSymbol> typeParameters)
			=> typeParameters
				.Select(t => ToCSharpGenericParameterConstraintsCode(t))
				.Where(t => !String.IsNullOrEmpty(t));

		private static string ToCSharpGenericParameterConstraintsCode(ITypeParameterSymbol typeParameter)
		{
			var constraints = new List<string>();

			if (typeParameter.HasReferenceTypeConstraint)
			{
				if (typeParameter.ReferenceTypeConstraintNullableAnnotation == NullableAnnotation.Annotated)
					constraints.Add("class?");
				else
					constraints.Add("class");
			}
			else if (typeParameter.HasUnmanagedTypeConstraint)
				constraints.Add("unmanaged");
			else if (typeParameter.HasValueTypeConstraint)
				constraints.Add("struct");
			else if (typeParameter.HasNotNullConstraint)
				constraints.Add("notnull");
			

			foreach (var set in typeParameter.ConstraintTypes.Zip(typeParameter.ConstraintNullableAnnotations, (type, nullable) => (type, nullable: nullable == NullableAnnotation.Annotated)))
			{
				var typeName = set.type is ITypeParameterSymbol parameter
					? parameter.Name
					: set.type.GetFullNameWithNamespace(".", true);

				if (set.nullable)
					constraints.Add($"{typeName}?");
				else
					constraints.Add(typeName);
			}

			if (typeParameter.HasConstructorConstraint)
				constraints.Add("new()");

			if (constraints.Any())
				return $"where {typeParameter.Name} : {String.Join(", ", constraints)}";

			return String.Empty;
		}
	}
}
