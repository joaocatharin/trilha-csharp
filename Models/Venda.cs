﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Diome.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto {  get; set; }
    }
}
