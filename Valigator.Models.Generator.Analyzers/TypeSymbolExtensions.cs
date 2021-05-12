using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Valigator.Models.Generator.Analyzers
{
	internal static class TypeSymbolExtensions
	{
		private static Dictionary<string, string> _primitiveMapping = new Dictionary<string, string>()
		{
			{ "System.Boolean", "bool" },
			{ "System.Byte", "byte" },
			{ "System.SByte", "sbyte" },
			{ "System.Char", "char" },
			{ "System.Decimal", "decimal" },
			{ "System.Double", "double" },
			{ "System.Single", "float" },
			{ "System.Int32", "int" },
			{ "System.UInt32", "uint" },
			{ "System.Int64", "long" },
			{ "System.UInt64", "ulong" },
			{ "System.Int16", "short" },
			{ "System.UInt16", "ushort" },
			{ "System.Object", "object" },
			{ "System.String", "string" }
		};

		public static bool TryGetTypeNameRelativeTo(this ITypeSymbol type, ITypeSymbol target, out string relativeName)
			=> TryGetRelativeTypeName
			(
				type.GetFullNameWithNamespace(".").Split('.'),
				target.GetFullNameWithNamespace(".").Split('.'),
				out relativeName
			);

		public static string GetTypeNameRelativeTo(this ITypeSymbol type, ITypeSymbol target)
		{
			TryGetTypeNameRelativeTo(type, target, out var relativeName);

			return relativeName;
		}

		public static bool TryGetTypeNameRelativeTo(this ITypeSymbol type, string target, out string relativeName)
			=> TryGetRelativeTypeName
			(
				type.GetFullNameWithNamespace(".").Split('.'),
				target.Split('.'),
				out relativeName
			);

		public static string GetTypeNameRelativeTo(this ITypeSymbol type, string target)
		{
			TryGetTypeNameRelativeTo(type, target, out var relativeName);

			return relativeName;
		}

		public static bool TryGetRelativeTypeNameFrom(this ITypeSymbol target, string type, out string relativeName)
			=> TryGetRelativeTypeName
			(
				type.Split('.'),
				target.GetFullNameWithNamespace(".").Split('.'),
				out relativeName
			);

		public static string GetRelativeTypeNameFrom(this ITypeSymbol target, string type)
		{
			TryGetRelativeTypeNameFrom(target, type, out var relativeName);

			return relativeName;
		}

		private static bool TryGetRelativeTypeName(string[] typeList, string[] targetList, out string relativeName)
		{
			var length = Math.Min(typeList.Length, targetList.Length);

			int i;
			for (i = 0; i < length; ++i)
			{
				if (typeList[i] != targetList[i])
					break;
			}

			relativeName = String.Join(".", typeList.Skip(i));
			return i != 0;
		}

		public static IEnumerable<ITypeSymbol> GetContainingTypeHierarchy(this ITypeSymbol type)
		{
			if (type.ContainingType != null)
				foreach (var t in type.ContainingType.GetContainingTypeHierarchy())
					yield return t;
			yield return type;
		}

		public static IEnumerable<ITypeSymbol> GetBaseTypeHierarchy(this ITypeSymbol type)
		{
			if (type.BaseType != null)
				foreach (var t in type.BaseType.GetBaseTypeHierarchy())
					yield return t;
			yield return type;
		}

		public static IEnumerable<INamedTypeSymbol> GetContainingTypeHierarchy(this INamedTypeSymbol type)
		{
			if (type.ContainingType != null)
				foreach (var t in type.ContainingType.GetContainingTypeHierarchy())
					yield return t;
			yield return type;
		}

		public static IEnumerable<INamedTypeSymbol> GetBaseTypeHierarchy(this INamedTypeSymbol type)
		{
			if (type.BaseType != null)
				foreach (var t in type.BaseType.GetBaseTypeHierarchy())
					yield return t;
			yield return type;
		}

		public static IEnumerable<TypeDeclarationSyntax> GetDeclaringSyntaxReferences(this ITypeSymbol typeSymbol, CancellationToken cancellationToken)
			=> typeSymbol
				.DeclaringSyntaxReferences
				.Select(s => s.GetSyntax(cancellationToken))
				.OfType<TypeDeclarationSyntax>();

		public static bool IsDerivedFrom(this ITypeSymbol symbol, INamedTypeSymbol attributeTypeSymbol)
		{
			if (symbol.Equals(attributeTypeSymbol, SymbolEqualityComparer.Default))
				return true;

			if (symbol.BaseType != null)
				return symbol.BaseType.IsDerivedFrom(attributeTypeSymbol);

			return false;
		}

		public static string GetFullNameWithNamespace(this ITypeSymbol typeSymbol, string classSeparator)
		{
			var ns = typeSymbol.GetFullNamespace();
			var typeName = String.Join(classSeparator, typeSymbol.GetContainingTypeHierarchy().Select(t => t.Name));

			if (String.IsNullOrEmpty(ns))
				return typeName;

			var name = $"{ns}.{typeName}";

			if (_primitiveMapping.TryGetValue(name, out var primitiveName))
				return primitiveName;

			return name;
		}

		public static string GetFullNamespace(this ITypeSymbol typeSymbol)
			=> typeSymbol.ContainingNamespace.GetFullNamespace();

		private static string GetFullNamespace(this INamespaceSymbol namespaceSymbol)
			=> namespaceSymbol.ContainingNamespace != null && !namespaceSymbol.ContainingNamespace.IsGlobalNamespace
				? $"{namespaceSymbol.ContainingNamespace.GetFullNamespace()}.{namespaceSymbol.Name}"
				: namespaceSymbol.Name;

		public static IEnumerable<IPropertySymbol> GetProperties(this ITypeSymbol typeSymbol)
			=> typeSymbol
				.GetMembers()
				.OfType<IPropertySymbol>();
	}
}
