using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Check.Point.Mvc.Web.Models;
using Senai.Check.Point.Mvc.Web.Repositorios;

namespace Senai.Check.Point.Mvc.Web.Controllers
{
    public class ComentarioController : Controller
    {
        public ComentarioRepositorio ComentarioRepositorio { get; set; }
        public ComentarioController()
        {
            ComentarioRepositorio = new ComentarioRepositorio();
        }
        [HttpGet]
        public IActionResult Comentario(){
            if (HttpContext.Session.GetString("Nome") != null)
            {
                return View();
            }
            else
            {
               return Redirect("/Pagina/Home");    
            }
            
        }

        [HttpPost]
        public ActionResult Comentario(IFormCollection form){
            string nomeUsuario = HttpContext.Session.GetString("Nome");
            ComentarioModel comentario = new ComentarioModel();
             int id = 0;
             bool status = false;
            if (System.IO.File.Exists("comentarios.csv")) {
                string[] lines = System.IO.File.ReadAllLines ("comentarios.csv");
                id = lines.Length + 1;
            } else {
                id = 1;
            }
            comentario.IdArea = 1;
            comentario.Id = id;
            comentario.Nome = nomeUsuario;
            comentario.Texto = form["texto"];
            comentario.Status = status;
            comentario.DataCriacao = DateTime.Now;
            using(StreamWriter sw = new StreamWriter("comentarios.csv",true)){
                sw.WriteLine($"{comentario.Id};{comentario.IdArea};{comentario.Nome};{comentario.Texto};{comentario.Status};{comentario.DataCriacao}");
            }
            ViewBag.Mensagem = "Comentario Feito";
            return View();
        }

        [HttpGet]
        public ActionResult ListarComentario () {
            ViewData["Comentarios"] = ComentarioRepositorio.Listar();
            return View ();
        }

        [HttpGet]
        public IActionResult ComentarioAprovado (int id){
            ComentarioRepositorio.Aprovar(id);
            TempData["Mensagem"] ="Comentario  Aprovado";
            return RedirectToAction ("ListarComentario","Comentario");

        }
        public IActionResult ComentarioExcluir (int id){
            ComentarioRepositorio.Excluir(id);
            TempData["Mensagem"] = "Comentario Excluir";
            return RedirectToAction ("ListarComentario","Comentario");
        }
        [HttpGet]
        public IActionResult ComentarioRecusado (int id){
            ComentarioRepositorio.Recusar(id);
            TempData["Mensagem"] ="Comentario Recusar";
            return RedirectToAction ("ListarComentario","Comentario");
        }
    }    
}