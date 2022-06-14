using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeContatos.Classes
{
    public static class Sistema
    {
        public static List<Contato> Contatos = new List<Contato>();

        public static void CadastrarContatos()
        {
            Contatos.Add(new Contato
            {
                Nome = "Kevin",
                Idade = 0,
                Telefone = "+55 (41) 99121-4268",
            });

            Contatos.Add(new Contato
            {
                Nome = "Erick Krzyzanovski",
                Idade = 0,
                Telefone = "+55 (41) 99281-8738",
            });

            Contatos.Add(new Contato
            {
                Nome = "Alexandre",
                Idade = 21,
                Telefone = "+55 (41) 99988-9999",
            });

            Contatos.Add(new Contato
            {
                Nome = "Joao",
                Idade = 21,
                Telefone = "+55 (41) 99988-9999",
            });
        }

        public static void ImprimirContatos()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("                           Listagem de Contatos                                 ");

            foreach (Contato contato in Contatos)
            {
                contato.Imprime();
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

        }


        public static void CadastrarNovoContato()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("                          Cadastro de Contatos                                  ");
            Console.WriteLine("--------------------------------------------------------------------------------");

            var _contato = new Contato();

            Console.Write("Digite o Nome: ");
            _contato.Nome = Console.ReadLine();

            Console.Write("Digite a Idade: ");
            _contato.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Telefone: ");
            _contato.Telefone = Console.ReadLine();



            Contatos.Add(_contato);
            Console.Clear();
            Console.WriteLine("Contato Cadastrado com Sucesso!");
            _contato.Imprime();
            Console.WriteLine("--------------------------------------------------------------------------------");

        }

        public static void BuscarContato()
        {
           

        }

        public static void ExcluirContato()
        {


        }
















    }
}
