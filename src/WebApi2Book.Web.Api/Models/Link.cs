﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2Book.Web.Api.Models
{
	public class Link
	{
	    public string Rel { get; set; }
	    public string Href { get; set; }
	    public string Method { get; set; }
	}
}