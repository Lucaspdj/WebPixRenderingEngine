using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPixCoreUI.Models
{
    public class LoginViewModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public int idCliente { get; set; }
        public int idPerfil { get; set; }
        public int IdUsuario { get; set; }

    }
}