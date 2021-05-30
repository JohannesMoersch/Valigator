﻿using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models.Generator.Tests
{
	public static class TypeAssertionsExtensions
	{
		public static AndConstraint<TypeAssertions> HaveParentClassesOf(this TypeAssertions type, params string[] parentClasses)
		{
			(type.Subject.DeclaringType?.GetContainingTypeHierarchy() ?? Enumerable.Empty<Type>())
				.Select(t => t.Name)
				.Should()
				.BeEquivalentTo(parentClasses);

			return new AndConstraint<TypeAssertions>(type);
		}

		public static AndConstraint<TypeAssertions> HaveSameParentClassesAs(this TypeAssertions type, Type other)
		{
			(type.Subject.DeclaringType?.GetContainingTypeHierarchy() ?? Enumerable.Empty<Type>())
				.Should()
				.BeEquivalentTo(other.DeclaringType?.GetContainingTypeHierarchy() ?? Enumerable.Empty<Type>());

			return new AndConstraint<TypeAssertions>(type);
		}

		public static AndConstraint<TypeAssertions> HaveParentClassesOfType(this TypeAssertions type, params ObjectType[] parentClassTypes)
		{
			(type.Subject.DeclaringType?.GetContainingTypeHierarchy() ?? Enumerable.Empty<Type>())
				.Select(t => t.GetObjectType())
				.Should()
				.BeEquivalentTo(parentClassTypes);

			return new AndConstraint<TypeAssertions>(type);
		}

		public static AndConstraint<TypeAssertions> HaveNamespaceOf(this TypeAssertions type, string @namespace)
			=> type.Match(t => t.Namespace == @namespace);

		public static AndConstraint<TypeAssertions> HaveSameNamespaceAs(this TypeAssertions type, Type other)
			=> type.Match(t => t.Namespace == other.Namespace);

		public static AndConstraint<TypeAssertions> HaveGenericTypeParameter(this TypeAssertions type, int index)
			=> type.HaveGenericTypeParameter(index, _ => { });

		public static AndConstraint<TypeAssertions> HaveGenericTypeParameter(this TypeAssertions type, int index, Action<TypeAssertions> typeParameterValidator)
		{
			type.Subject.IsGenericTypeDefinition.Should().BeTrue();
			type.Subject.GetGenericArguments().Should().HaveCountGreaterThan(index);
			typeParameterValidator.Invoke(type.Subject.GetGenericArguments()[index].Should());

			return new AndConstraint<TypeAssertions>(type);
		}

		public static AndConstraint<TypeAssertions> HaveReferenceTypeConstraint(this TypeAssertions type)
			=> type
				.Match(t => t.GenericParameterAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint));

		public static AndConstraint<TypeAssertions> HaveNotNullableValueTypeConstraint(this TypeAssertions type)
			=> type
				.Match(t => t.GenericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint));

		public static AndConstraint<TypeAssertions> HaveDefaultConstructorConstraint(this TypeAssertions type)
			=> type
				.Match(t => t.GenericParameterAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint));

		public static AndConstraint<TypeAssertions> HaveDerivesFromConstraint(this TypeAssertions type, params Type[] baseTypes)
		{
			type
				.Subject
				.GetGenericParameterConstraints()
				.Should()
				.BeEquivalentTo(baseTypes);

			return new AndConstraint<TypeAssertions>(type);
		}
	}
}