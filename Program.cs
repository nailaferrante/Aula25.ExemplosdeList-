using System;
using System.Collections.Generic;

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> cidades = new List<string>();
            // cidades.Add("São Paulo");
            // cidades.Add("Curitiba");
            // cidades.Add("Osasco");
            // cidades.Add("Manaus");
            
            // Console.WriteLine(cidades[1].ToUpper());

            // List<Usuarios> us = new List<Usuarios>();
            // Usuarios lucas = new Usuarios(){ Id=35, Login = "lucas", Senha = "12345" };
            // Usuarios tuanny = new Usuarios(){ Id = 10, Login = "tuanny", Senha = "12"};

            // us.Add(lucas);
            // us.Add(tuanny);

            // Console.WriteLine(us[0].Login);

            List<Produto> sacola = new List<Produto>();
            HigienePessoal sabonete = new HigienePessoal();
            sabonete.Id = 10;
            sabonete.Nome = "Dove";
            sabonete.Marca = "Unilever";
            sabonete.NumeroMS = "100";
            sabonete.Preco = 4.00;


            Bebidas cerveja = new Bebidas();
            cerveja.Id = 10;
            cerveja.Nome = "Skol";
            cerveja.Preco = 7.00;
            cerveja.TeorAlcolico = 5.00;
            cerveja.Tipo = "Comum";


            sacola.Add(sabonete);
            sacola.Add(cerveja);

            foreach (var item in sacola) // percorre os itens da sacola
            {
                string classe = item.GetType().ToString(); // .GetType() pega o tipo da classe do item

                switch(classe)
                {
                    case "ExemploLista.HigienePessoal": // se for a classe HigienePessoal / no case eu informo o nome nome do projeto + nome da classe
                    {
                        HigienePessoal higiene = (HigienePessoal)item; // criando objeto do tipo HigienePessoal, item sem o (HigienePessoal) é do tipo Produto portanto é necessária a conversão. //cast
                        Console.WriteLine("Higiene Pessoal: " + higiene.Nome + " - " + higiene.NumeroMS + " - " + higiene.Marca);
                        break;
                    }

                    case "ExemploLista.Bebidas":{
                        Bebidas bebida = (Bebidas)item;
                        Console.WriteLine("Bebidas: "+ bebida.Nome + " - " + bebida.TeorAlcolico + " - " + bebida.Tipo);
                    }
                    break;
                }

            }
            
        }
    }
}
