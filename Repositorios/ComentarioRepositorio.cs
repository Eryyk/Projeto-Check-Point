using System;
using System.Collections.Generic;
using System.IO;
using Senai.Check.Point.Mvc.Web.Models;

namespace Senai.Check.Point.Mvc.Web.Repositorios
{
    public class ComentarioRepositorio
    {
        public List<ComentarioModel> Listar () => CarregarComentarioCSV ();

        private List<ComentarioModel> CarregarComentarioCSV () {
            List<ComentarioModel> lsComentario = new List<ComentarioModel> ();
            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines ("comentarios.csv");

            foreach (string linha in linhas) {
                if(string.IsNullOrEmpty(linha)){
                    continue;
                }

                string[] dadosDaLinha = linha.Split (';');

                ComentarioModel comentario = new ComentarioModel {
                    Id = int.Parse (dadosDaLinha[0]),
                    IdArea = int.Parse (dadosDaLinha[1]),
                    Nome = dadosDaLinha[2],
                    Texto = dadosDaLinha[3],
                    Status = bool.Parse(dadosDaLinha[4]),
                    DataCriacao = DateTime.Parse (dadosDaLinha[5])
                };
                lsComentario.Add (comentario);
            }
            return lsComentario;
        }

        public void Aprovar (int id) {
            string[] linhas = File.ReadAllLines ("comentarios.csv");

            for (int i = 0; i < linhas.Length; i++){
                string[] dadosDaLinha = linhas[i].Split(';');

                if(id.ToString() == dadosDaLinha[0]){
                    linhas[i] = ($"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};{true};{dadosDaLinha[5]}");
                }
            }
            File.WriteAllLines("comentarios.csv", linhas);
        }
        public void Excluir (int id) {
            string[] linhas = File.ReadAllLines ("comentarios.csv");

            for (int i = 0; i < linhas.Length; i++){
                string[] dadosDaLinha = linhas[i].Split(';');

                if(id.ToString() == dadosDaLinha[0]){
                    linhas[i] = "";
                }
            }
            File.WriteAllLines("comentarios.csv", linhas);
        }
        public void Recusar(int id) {
            string[] linhas = File.ReadAllLines("comentarios.csv");

            for(int i = 0; i < linhas.Length; i++){
                string[] dadosDaLinha = linhas[i].Split(';');

                if(id.ToString() == dadosDaLinha[0]){
                    linhas[i] = ($"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};{false};{dadosDaLinha[5]}");
                }
            }
            File.WriteAllLines("comentarios.csv", linhas);
        }
    }
}