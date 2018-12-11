using System;
using System.Collections.Generic;
using System.IO;
using Senai.Check.Point.Mvc.Web.Models;
namespace Senai.Check.Point.Mvc.Web.Reposirorios{
    public class UsuarioRepositorio {
       private List<UsuarioModel> CarregarDoCSV(){
           List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();
            string[] linhas = File.ReadAllLines("usuarios.csv");
            foreach (string linha in linhas){
                string[] dadosDaLinha = linha.Split(';');
                UsuarioModel usuario = new UsuarioModel{
                    Nome = dadosDaLinha[1],
                    Email = dadosDaLinha[2],
                    Senha = dadosDaLinha[3]
                };
                lsUsuarios.Add(usuario);
            }
            return lsUsuarios;
        }
        public UsuarioModel BuscarProEmailESenha(string email, string senha){
            List<UsuarioModel> usuariosCadastrados = CarregarDoCSV();
            foreach (UsuarioModel usuario in usuariosCadastrados)
            {
                if (usuario.Email == email && usuario.Senha == senha)
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}