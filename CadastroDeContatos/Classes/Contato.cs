using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeContatos.Classes
{
    public class Contato
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }

        public void BuscarContatos()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Telefone: {Telefone}");
        }

    }
}
