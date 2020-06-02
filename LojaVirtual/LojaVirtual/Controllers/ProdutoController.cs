﻿using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        [HttpGet]
        [Route("Produto/Categoria/{slug}")]
        public IActionResult ListagemCategoria(string slug)
        {
            return View();
        }
        /*
         *ActionResult
         *IActionResult
         */

        /*
         * Exemplo 1
        //public string Visualizar()
        //{
        //    //return new ContentResult() { Content = "<h3>Produto -> Visualizar<h3>", ContentType = "text/html" };
        //    return "Produto -> Visualizar";
        //}
        */

        public ActionResult Visualizar()
        {
            Produto produto = GetProduto();

            return View(produto);
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox One X",
                Descricao = "Jogue em 4k",
                Valor = 2000.00M
            };
        }

        
    }
}
