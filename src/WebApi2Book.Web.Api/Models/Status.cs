using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2Book.Web.Api.Models
{
    public class Status
    {
        public long StatusId { get; set; }
        public string Nome { get; set; }
        public int Ordinal { get; set; }
    }
}