﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Arquivo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ImagemController : Controller
    {
        public IActionResult Armazenar(IFormFile file)
        {
           var Caminho = GerenciadorArquivo.CadastrarImagemProduto(file);

            if (Caminho.Length > 0)
            {
                return Ok(new { caminho = Caminho }); 
            }
            else
            {
                return new StatusCodeResult(500);
            }
        }

        public IActionResult Deletar(string caminho)
        {
            if (GerenciadorArquivo.ExcluirImagemProduto(caminho))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

//Status do HTTP - 200 -> Sucesso.
//Status do HTTP - 300 -> Redirecionar.
//Status do HTTP - 400 -> Erro lado cliente.
//Status do HTTP - 500 -> Lado servidor.
//JSON -> JavaScript - JavaScript Object Notation
