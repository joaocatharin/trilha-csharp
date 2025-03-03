using System.Runtime.Serialization;
using System;
using System.Linq.Expressions;
using Newtonsoft.Json;
using Serializacao.Models;


// DESERIALIZAÇÃO

string conteudoArquivo = File.ReadAllText("Models/Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}






// SERIALIZAÇÃO

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVenda = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00m, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00m, dataAtual);

// listaVenda.Add(v1);
// listaVenda.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// File.WriteAllText("Models/Arquivos/vendas.json", serializado);


// Console.WriteLine(serializado);