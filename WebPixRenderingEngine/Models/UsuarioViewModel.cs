using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPixCoreUI.Models
{
    public class UsuarioViewModel : Base
    {
        public string Login { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public int PerfilUsuario { get; set; }
        public string Senha { get; set; }
    }
}