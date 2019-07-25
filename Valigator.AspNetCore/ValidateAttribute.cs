using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Valigator.Core;

namespace Valigator
{
	public abstract class ValidateAttribute : Attribute, IVerifiable, IDescriptor
	{
		public DataDescriptor GetDescriptor(Type type) => this.GetDataDescriptor(type);
		public Result<object, ValidationError[]> Verify(Type type, object value) => this.VerifyObject(type, value);
		public Result<object, ValidationError[]> Verify(Type type) => this.VerifyObject(type);
	}
}
