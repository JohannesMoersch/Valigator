using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers.Extensions
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
			if (!IsEqual(left.NullableAnnotation, right.NullableAnnotation))
				return false;

			if (left is ITypeParameterSymbol leftParameter && right is ITypeParameterSymbol rightParameter)
				return left.Name == right.Name;

			if (left is INamedTypeSymbol leftSymbol && right is INamedTypeSymbol rightSymbol)
				return SymbolEqualityComparer.Default.Equals(leftSymbol.OriginalDefinition, rightSymbol.OriginalDefinition)
					&& leftSymbol.TypeArguments.SequenceEqual(rightSymbol.TypeArguments, IsEqual);

			return SymbolEqualityComparer.Default.Equals(left.OriginalDefinition, right.OriginalDefinition);
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
				if (typeParameter.ReferenceTypeConstraintNullableAnnotation == NullableAnnotation.Annotated)
					constraints.Add("class?");
				else
					constraints.Add("class");
			else if (typeParameter.HasUnmanagedTypeConstraint)
				constraints.Add("unmanaged");
			else if (typeParameter.HasValueTypeConstraint)
				constraints.Add("struct");
			else if (typeParameter.HasNotNullConstraint)
				constraints.Add("notnull");


			foreach (var type in typeParameter.ConstraintTypes)
				constraints.Add(type.ToCSharpTypeCode());

			if (typeParameter.HasConstructorConstraint)
				constraints.Add("new()");

			if (constraints.Any())
				return $"where {typeParameter.Name} : {String.Join(", ", constraints)}";

			return String.Empty;
		}
	}
}
