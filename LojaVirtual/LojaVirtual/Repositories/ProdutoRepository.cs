﻿using LojaVirtual.Database;
using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories.Contracts
{
    public class ProdutoRepository : IProdutoRepository
    {
        private IConfiguration _conf;
        private LojaVirtualContext _banco;

        public ProdutoRepository(LojaVirtualContext banco, IConfiguration conf)
        {
            _banco = banco;
            _conf = conf;
        }

        public void Atualizar(Produto produto)
        {
            _banco.Update(produto);
            _banco.SaveChanges();
        }

        public void Cadastrar(Produto produto)
        {
            _banco.Add(produto);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Produto produto = ObterProduto(Id);
            _banco.Remove(produto);
            _banco.SaveChanges();
        }

        public Produto ObterProduto(int Id)
        {
            return _banco.Produtos.Include(a => a.Imagens).OrderBy(a=>a.Nome).Where(a => a.Id == Id).FirstOrDefault();
        }  

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa)
        {
            return ObterTodosProdutos(pagina, pesquisa, "A");
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa, string ordenacao)
        {
            int RegistroPorPagina = _conf.GetValue<int>("RegistroPorPagina");
            int NumeroPagina = pagina ?? 1;
            var bancoProduto = _banco.Produtos.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                bancoProduto = bancoProduto.Where(a => a.Nome.Contains(pesquisa.Trim()));
            }
            if (ordenacao == "A")
            {
                bancoProduto = bancoProduto.OrderBy(a => a.Nome);
            }
            if (ordenacao == "ME")
            {
                bancoProduto = bancoProduto.OrderBy(a => a.Valor);
            }
            if (ordenacao == "MA")
            {
                bancoProduto = bancoProduto.OrderByDescending(a => a.Valor);
            }

            return bancoProduto.Include(a => a.Imagens).ToPagedList<Produto>(NumeroPagina, RegistroPorPagina);

        }
    
    }
}
