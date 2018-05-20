using MarabotaBotsProjeto.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarabotaBotsProjeto.Controllers
{
    public class InformacoesController : Controller
    {
        // GET: Informacoes
        public JsonResult CaracteristicasFisicas(string raca)
        {
            List<string> info = Informacoes.CaracteristicasFisicas(raca);
            Resposta r = new Resposta {
                raca = info[0],
                informacoes = "Características Físicas",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CaracteristicasComportamentais(string raca)
        {
            List<string> info = Informacoes.CaracteristicasComportamentais(raca);
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "Características Comportamentais",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Problemas(string raca)
        {
            List<string> info = Informacoes.Problemas(raca);
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "Problemas",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Cuidados(string raca)
        {
            List<string> info = Informacoes.Cuidados(raca);
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "Cuidados",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Imagens(string raca)
        {
            List<string> info = Informacoes.Imagens(raca);
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "Imagens",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Origem(string raca)
        {
            List<string> info = Informacoes.Origem(raca);
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "Origem",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult PaisDeOrigem(string raca)
        {
            List<string> info = Informacoes.Origem(raca);
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "País de Origem",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Curiosidades(string raca)
        {
            List<string> info = Informacoes.Curiosidades(raca);
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "Curiosidades",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Idade(string raca)
        {
            List<string> info = Informacoes.Idade();
            Resposta r = new Resposta
            {
                raca = info[0],
                informacoes = "Idade",
                texto = info[1]
            };
            return Json(r, JsonRequestBehavior.AllowGet);
        }
    }
}