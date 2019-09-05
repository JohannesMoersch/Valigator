using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Valigator.AspNetCore;
using Valigator.Core;

namespace Valigator
{
	public abstract class ValidateAttribute : Attribute, IVerifiable, IDescriptorProvider { }
}
