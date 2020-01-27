using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        /*
         * Nome: Informática
         * Slug: 
         * URL Normal: www.lojavirtual.com.br/categoria/5
         * URL Amigável e com Slug: www.lojavirtual.com.br/categoria/informativa (Url amigável)
         * Slug:
         */
        public string Slug { get; set; }

        /*
         * Auto-relacionamento
         * Informatica - P:null
         * - Mouse P:1
         * -- Mouse sem fio P:2
         * -- Mouse gamer P:2
         */
        public int? CategoriaPaiId { get; set; }

        /*
         * ORM - EntityFrameworkCore
         */
         [ForeignKey("CategoriaPaiId")]
        public virtual Categoria CategoriaPai { get; set; }
    }
}
