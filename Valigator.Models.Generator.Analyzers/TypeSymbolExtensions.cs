using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator
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

		public static string GetTypeNameRelativeTo(this ITypeSymbol type, ITypeSymbol target)
		{
			var typeList = type.GetFullNameWithNamespace().Split('.');
			var targetList = target.GetFullNameWithNamespace().Split('.');

			var length = Math.Min(typeList.Length, targetList.Length);

			for (int i = 0; i < length; ++i)
			{
				if (typeList[i] != targetList[i])
					return String.Join(".", typeList.Skip(i));
			}

			return String.Join(".", typeList.Skip(length));
		}

		public static string GetTypeNameRelativeTo(this ITypeSymbol type, string target)
		{
			var typeList = type.GetFullNameWithNamespace().Split('.');
			var targetList = target.Split('.');

			var length = Math.Min(typeList.Length, targetList.Length);

			for (int i = 0; i < length; ++i)
			{
				if (typeList[i] != targetList[i])
					return String.Join(".", typeList.Skip(i));
			}

			return String.Join(".", typeList.Skip(length));
		}

		private static IEnumerable<ITypeSymbol> GetTypeHierarchy(this ITypeSymbol type)
		{
			if (type.ContainingType != null)
			{
				foreach (var t in type.ContainingType.GetTypeHierarchy())
					yield return t;
			}
			yield return type;
		}

		public static bool HasAttribute(this ITypeSymbol typeSymbol, INamedTypeSymbol attributeTypeSymbol)
			=> typeSymbol
				.GetAttributes()
				.Any(att => att.AttributeClass?.Equals(attributeTypeSymbol, SymbolEqualityComparer.Default) ?? false);

		public static string GetFullNameWithNamespace(this ITypeSymbol typeSymbol)
		{
			var ns = typeSymbol.GetFullNamespace();
			var typeName = String.Join(".", typeSymbol.GetTypeHierarchy().Select(t => t.Name));
			
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
	}
}
