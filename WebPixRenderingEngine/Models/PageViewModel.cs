using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPixCoreUI.Models
{
    public class PageViewModel : Base
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Url { get; set; }
        public int idMenu { get; set; }
        public Byte[] pagina { get; set; }
    }
}