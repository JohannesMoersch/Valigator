using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace Valigator.Core
{
	/// <summary>
	/// Create a Valigator Model. The inner object will be validated as a if it had a [ValigatorModel] attribute on it.
	/// </summary>
	public class ValigatorModelBase : DynamicObject
	{
		private readonly ConcurrentDictionary<string, object> _dictionary = new ConcurrentDictionary<string, object>();
		protected readonly object Inner;

		public ValigatorModelBase(object inner)
		{
			Inner = inner;
			SetupDictionary();
		}

		public T GetMember<T>(string name) => (T)(_dictionary.TryGetValue(name, out var value) ? value : null);
		public void SetMember<T>(string name, T value) => _dictionary.AddOrUpdate(name, value, (_, __) => value);

		private void SetupDictionary()
		{
			foreach (var property in Inner.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
				_dictionary.TryAdd(property.Name, property.GetValue(Inner));
		}

		public object GetInner() => Inner;

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			return base.TryGetMember(binder, out result);
		}

		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			return base.TrySetMember(binder, value);
		}
	}
}
