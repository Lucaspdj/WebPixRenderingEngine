using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPixCoreUI.Models
{
    public class ClienteViewModel : Base
    {
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}