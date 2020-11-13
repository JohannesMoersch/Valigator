using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Valigator.Core
{
	//TODO: Nathan make this into a dictionary so that it outputs properly via valigator.
	// Or perhaps make a custom converter for it.
	public abstract class ValigatorModelBase : CustomTypeDescriptor
	{
		private readonly ConcurrentDictionary<string, object> _dictionary = new ConcurrentDictionary<string, object>();
		protected readonly object Inner;

		//public ICollection<string> Keys => throw new NotImplementedException();

		//public ICollection<object> Values => throw new NotImplementedException();

		//public int Count => throw new NotImplementedException();

		//public bool IsReadOnly => throw new NotImplementedException();

		//public object this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public ValigatorModelBase(object inner)
		{
			Inner = inner;
			SetupDictionary();
		}

		public T GetMember<T>(string name) => (T)(_dictionary.TryGetValue(name, out var value) ? value : null);
		public T SetMember<T>(string name, T value) => (T)_dictionary.AddOrUpdate(name, value, (_, __) => value);

		private void SetupDictionary()
		{
			foreach (var property in Inner.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
				_dictionary.TryAdd(property.Name, property.GetValue(Inner));
		}

		public override PropertyDescriptorCollection GetProperties()
			=> new PropertyDescriptorCollection(base.GetProperties().OfType<System.ComponentModel.PropertyDescriptor>().Concat(GetExpandoProperties()).ToArray());

		private IEnumerable<System.ComponentModel.PropertyDescriptor> GetExpandoProperties()
			=> _dictionary.Select(property => new ExpandoPropertyDescriptor(_dictionary, property.Key));

		public override string GetClassName() => $"{nameof(ValigatorModelBase)}_{Inner.GetType().Name}";
		public object GetInner() => Inner;

		//public void Add(string key, object value) => _dictionary.TryAdd(key, value);
		//public bool ContainsKey(string key) => _dictionary.ContainsKey(key);
		//public bool Remove(string key) => _dictionary.TryRemove(key, out var _);
		//public bool TryGetValue(string key, out object value) => _dictionary.TryGetValue(key, out value);
		//public void Add(KeyValuePair<string, object> item) => _dictionary.TryAdd(item.Key, item.Value);
		//public void Clear() => _dictionary.Clear();
		//public bool Contains(KeyValuePair<string, object> item) => _dictionary.Contains(item);

		//public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		//{
		//	foreach (var item in _dictionary)
		//		array[arrayIndex++] = item;
		//}
		//public bool Remove(KeyValuePair<string, object> item) => _dictionary.TryRemove(item.Key, out var _);
		//public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _dictionary.GetEnumerator();
		//IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		private class ExpandoPropertyDescriptor : System.ComponentModel.PropertyDescriptor
		{
			private readonly IDictionary<string, object> _dictionary;
			private readonly string _name;

			public ExpandoPropertyDescriptor(IDictionary<string, object> expando, string name)
				: base(name, null)
			{
				_dictionary = expando;
				_name = name;

				AttributeArray = new[] { new ValidateContentsAttribute() };
			}

			protected override Attribute[] AttributeArray { get => base.AttributeArray; set => base.AttributeArray = value; }
			public override AttributeCollection Attributes => base.Attributes;
			protected override AttributeCollection CreateAttributeCollection()
			{
				return base.CreateAttributeCollection();
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
