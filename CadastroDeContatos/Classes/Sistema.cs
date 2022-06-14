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

        public static void CadastrarContato()
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
            Console.WriteLine("                           Listagem de Clientes                                 ");

            foreach (Contato contato in Contatos)
            {
                contato.BuscarContatos();
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

        }





















    }
}
