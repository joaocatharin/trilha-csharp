using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TesteAPI.Entities
{
    public class Contato
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public bool Ativo { get; set; }
}
}