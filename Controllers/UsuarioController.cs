using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Check.Point.Mvc.Web.Models;
using Senai.Check.Point.Mvc.Web.Reposirorios;

namespace Senai.Check.Point.Mvc.Web.Controllers {
    public class UsuarioController : Controller {

        [HttpGet]

        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]

        public ActionResult Cadastrar (IFormCollection form) {

            if (form["senha"] != form["confirme"]) {
                ViewBag.Mensagem = "Coleque a mesma senha nas duas àreas";
                return View ();
            }
            UsuarioModel usuarioModel = new UsuarioModel ();

            int id = 0;
            if (System.IO.File.Exists ("usuarios.csv")) {
                string[] lines = System.IO.File.ReadAllLines ("usuarios.csv");
                id = lines.Length + 1;
            } else {
                id = 2;
            }
            usuarioModel.ID = id;
            usuarioModel.Nome = form["nome"];
            usuarioModel.Email = form["email"];
            usuarioModel.Senha = form["senha"];

            if (!System.IO.File.Exists ("usuarios.csv")) {
                using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                    sw.WriteLine ($"{1};{"Admin"};{"admin@admin.com"};{"admin"}");
                }
                using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                    sw.WriteLine ($"{usuarioModel.ID};{usuarioModel.Nome};{usuarioModel.Email};{usuarioModel.Senha}");
                }
            } else {
                using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                    sw.WriteLine ($"{usuarioModel.ID};{usuarioModel.Nome};{usuarioModel.Email};{usuarioModel.Senha}");
                }
            }
            ViewBag.Mensagem = "Usuário cadastrado com sucesso!";
            return View ();
        }

        [HttpGet]
        public ActionResult Login () => View ();

        [HttpPost]
        public IActionResult Login (IFormCollection form) {


            UsuarioModel usuario = new UsuarioModel {
                Email = form["email"],
                Senha = form["senha"]
            };

            UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();
            UsuarioModel usuarioModel = usuarioRep.BuscarProEmailESenha (usuario.Email, usuario.Senha);

            if (usuarioModel != null) {
                HttpContext.Session.SetString ("Nome", usuarioModel.Nome);
                ViewBag.Mensagem = "Login realizado com sucesso";
                if (usuarioModel.Email == "admin@admin.com" && usuarioModel.Senha == "admin") {
                    ViewBag.Mensagem = "Login realizado com sucesso!";
                    return RedirectToAction ("ListarComentario", "Comentario");
                }
            } else {
                ViewBag.Mensagem = "Login negado";
            }
            return View ();
        }

    }
}