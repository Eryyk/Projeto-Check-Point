using System;

namespace Senai.Check.Point.Mvc.Web.Models{
    public class UsuarioModel{
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Admin { get; set; }
    }
}