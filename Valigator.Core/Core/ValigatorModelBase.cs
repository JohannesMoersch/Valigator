using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace Valigator.Core
{
	/// <summary>
	/// Create a Valigator Model. The inner object will be validated as a if it had a [ValigatorModel] attribute on it.
	/// </summary>
	public abstract class ValigatorModelBase
	{
		protected readonly ConcurrentDictionary<string, object> Dictionary = new ConcurrentDictionary<string, object>();
		protected readonly object Inner;

		public ValigatorModelBase(object inner)
		{
			Inner = inner;
			SetupDictionary();
		}

		private void SetupDictionary()
		{
			foreach (var property in Inner.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
				Dictionary.TryAdd(property.Name, property.GetValue(Inner));
		}

		public object GetInner() => Inner;
		public Type GetInnerType() => Inner.GetType();

		public object GetMember(string name) => (Dictionary.TryGetValue(name, out var value) ? value : null);
		public void SetMember(string name, object value) => Dictionary.AddOrUpdate(name, value, (_, __) => value);
	}
	/// <summary>
	/// Create a Valigator Model. The inner object will be validated as a if it had a [ValigatorModel] attribute on it.
	/// </summary>
	public abstract class ValigatorModelBase<TInner> : ValigatorModelBase
	{
		public ValigatorModelBase(TInner inner) : base(inner) { }
	}
}
