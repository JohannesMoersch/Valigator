using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Valigator.Core
{
	public abstract class ValigatorModelBase : CustomTypeDescriptor, ICustomTypeDescriptor
	{
		private readonly ConcurrentDictionary<string, object> _dictionary = new ConcurrentDictionary<string, object>();
		protected readonly object Inner;

		public ValigatorModelBase(object inner)
		{
			Inner = inner;
			SetupDictionary();
		}

		public T GetMember<T>(string name)
			=> (T)(_dictionary.TryGetValue(name, out var value) ? value : null);

		public T SetMember<T>(string name, T value)
			=> (T)_dictionary.AddOrUpdate(name, value, (_, __) => value);

		private void SetupDictionary()
		{
			foreach (var property in Inner.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
				_dictionary.TryAdd(property.Name, property.GetValue(Inner));
		}

		public override AttributeCollection GetAttributes()
		{
			return base.GetAttributes();
		}

		public override PropertyDescriptorCollection GetProperties()
			=> new PropertyDescriptorCollection(base.GetProperties().OfType<System.ComponentModel.PropertyDescriptor>().Concat(GetExpandoProperties()).ToArray());

		private IEnumerable<System.ComponentModel.PropertyDescriptor> GetExpandoProperties()
			=> _dictionary.Select(property => new ExpandoPropertyDescriptor(_dictionary, property.Key));

		public override string GetClassName()
			=> $"{nameof(ValigatorModelBase)}_{Inner.GetType().Name}";

		public object GetInner()
			=> Inner;

		private class ExpandoPropertyDescriptor : System.ComponentModel.PropertyDescriptor
		{
			private readonly IDictionary<string, object> _dictionary;
			private readonly string _name;

			public ExpandoPropertyDescriptor(IDictionary<string, object> expando, string name)
				: base(name, null)
			{
				_dictionary = expando;
				_name = name;
			}

			public override Type PropertyType => _dictionary[_name].GetType();
			public override void SetValue(object component, object value) => _dictionary[_name] = value;
			public override object GetValue(object component) => _dictionary[_name];
			public override bool IsReadOnly { get; } = false;
			public override Type ComponentType { get; } = null;
			public override bool CanResetValue(object component) => false;
			public override void ResetValue(object component) { }
			public override bool ShouldSerializeValue(object component) => false;
			public override string Category { get; } = String.Empty;
			public override string Description { get; } = String.Empty;
		}
	}
}
