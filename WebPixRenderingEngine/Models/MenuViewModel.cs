using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPixCoreUI.Models
{
    public class MenuViewModel : Base
    {
        public string Url { get; set; }
        public int Pai { get; set; }
        public int Tipo { get; set; }
    }
}