using System;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Valigator.TestApi.Core31.MappedGuid
{
	public static class MappedGuidHelpers
	{
		public static Result<MappedGuid, Exception> Create(Guid MappedGuid)
			=> Valigator.Required.WithMappedValue(MappedGuid).Verify().TryGetValue().MapFailure(f => new Exception());

		public static Result<MappedGuid, Exception> Create(string MappedGuid)
			=> Guid.TryParse(MappedGuid, out var guid) ? Create(guid) : Result.Failure<MappedGuid, Exception>(new Exception($"'{MappedGuid}' must be a valid guid."));

		public static MappedGuid CreateNew() => new MappedGuid(Guid.NewGuid());

		public static class Valigator
		{
			private static readonly Data<Guid> _data = Data.Required<Guid>().NotEmpty();

			public static Data<MappedGuid> Required { get; } = Data.Required<MappedGuid>().MappedFrom<Guid>(CreateMappedGuid, _ => _data);

			public static Data<Option<MappedGuid>> Optional { get; } = Data.Optional<MappedGuid>().MappedFrom<Guid>(CreateMappedGuid, _ => _data);

			private static MappedGuid CreateMappedGuid(Guid guid)
				=> new MappedGuid(guid);
		}

		public abstract class MappedGuidValidateModelBinderAttribute : ValidateModelBinderAttribute
		{
			public abstract object GetData();
		}

		public static class ModelBindings
		{
			public static class Required
			{
				public abstract class BaseAttribute : MappedGuidValidateModelBinderAttribute
				{
					private readonly Data<MappedGuid> _data = Valigator.Required;

					public override object GetData() => _data;

					public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
						=> Task.FromResult(BindModelInternal(bindingContext));

					private BindResult BindModelInternal(ModelBindingContext bindingContext)
						=> BindResult.Create(GetGuidValue(bindingContext)
							.Match(
								s => _data.WithMappedValue(s),
								_data.WithErrors
							));

					private Result<Guid, ValidationError[]> GetGuidValue(ModelBindingContext bindingContext)
						=> Guid.TryParse(GetValue(bindingContext), out var guid)
							? Result.Success<Guid, ValidationError[]>(guid)
							: Result.Failure<Guid, ValidationError[]>(new[] { MappingError.Create("Error mapping input to Guid.", typeof(string), typeof(Guid)) });

					private string GetValue(ModelBindingContext bindingContext)
						=> bindingContext?.ValueProvider?.GetValue(bindingContext.FieldName).FirstOrDefault() ?? string.Empty;
				}

				public class PathAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Path;
				}

				public class QueryAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Query;
				}

				public class HeaderAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Header;
					public override string Name { get; set; } = "TheHeader";
				}
			}

			public static class Optional
			{
				public abstract class BaseAttribute : MappedGuidValidateModelBinderAttribute
				{
					private readonly Data<Option<MappedGuid>> _data = Valigator.Optional;

					public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
						=> Task.FromResult(BindModelInternal(bindingContext));

					private BindResult BindModelInternal(ModelBindingContext bindingContext)
						=> BindResult
							.Create(GetOptionGuidValue(bindingContext)
								.Match(
									s => s.Match(v => _data.WithMappedValue(v), () => _data.WithUncheckedValue(Option.None<MappedGuid>())),
									e => _data.WithErrors(e)
								));

					private Result<Option<Guid>, ValidationError[]> GetOptionGuidValue(ModelBindingContext bindingContext)
						=> GetValue(bindingContext).Match(
							some: value =>
								Guid.TryParse(value, out var guid)
									? Result.Success<Option<Guid>, ValidationError[]>(Option.Some(guid))
									: Result.Failure<Option<Guid>, ValidationError[]>(new[] { MappingError.Create("Error mapping input to Guid.", typeof(string), typeof(Guid)) }),
							none: () => Result.Success<Option<Guid>, ValidationError[]>(Option.None<Guid>()));

					private Option<string> GetValue(ModelBindingContext bindingContext)
						=> Option.FromNullable(bindingContext.ValueProvider.GetValue(bindingContext.FieldName).FirstOrDefault());

					public override object GetData() => _data;
				}

				public class PathAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Path;
				}

				public class QueryAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Query;
				}
			}
		}
	}
}
