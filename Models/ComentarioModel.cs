using System;
using Microsoft.Extensions.Primitives;

namespace Senai.Check.Point.Mvc.Web.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdArea { get; set; }
        public string Texto { get; set; }
        public bool Status { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}