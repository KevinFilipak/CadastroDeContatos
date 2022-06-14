using CadastroDeContatos.Classes;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

class Program
{

    static void Main()
    {
        Console.Title = $"Analise e Desenvolvimento de Sistemas - Estrutura de Dados";

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("===========================================================================================");
        Console.WriteLine();
        Console.WriteLine("          ██    ██   ████████   ████████           ████████   █████      ████████          ");
        Console.WriteLine("          ██    ██      ██      ██    ██           ██    ██   ██   ██    ██                ");
        Console.WriteLine("          ██    ██      ██      ████████   █████   ████████   ██    ██   ████████          ");
        Console.WriteLine("          ██    ██      ██      ██                 ██    ██   ██   ██          ██          ");
        Console.WriteLine("          ████████      ██      ██                 ██    ██   █████      ████████          ");
        Console.WriteLine();
        Console.WriteLine("Created By: Kevin Filipak // Erick Krzyzanovski");
        Console.WriteLine("===========================================================================================");

        Sistema.CadastrarContatos();

        Thread.Sleep(3000);


        Console.Clear();

        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("                             Estrutura de Dados                                 ");
        Console.WriteLine("                             Agenda de Contatos                                 ");
        Console.WriteLine("--------------------------------------------------------------------------------");

        var opcao = Menu();

        while (opcao != EnumOpcaoMenu.S)
        {
            Console.Clear();
            switch (opcao)
            {
                case EnumOpcaoMenu.A:
                    Sistema.CadastrarNovoContato();
                    break;
                case EnumOpcaoMenu.B:
                    Sistema.BuscarContato();
                    break;
                case EnumOpcaoMenu.C:
                    Sistema.ImprimirContatos();
                    Sistema.ExcluirContato();
                    break;
                case EnumOpcaoMenu.D:
                    Sistema.ImprimirContatos();
                    break;
                case EnumOpcaoMenu.S:
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            opcao = Menu();


        }

    }
    private static EnumOpcaoMenu Menu()
    {
        try
        {

            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("                             Estrutura de Dados                                 ");
            Console.WriteLine("                             Agenda de Contatos                                 ");
            Console.WriteLine("--------------------------------------------------------------------------------");

            var _lstMenu = Enum.GetValues(typeof(EnumOpcaoMenu));

            foreach (var _menu in _lstMenu)
            {
                Console.WriteLine(((EnumOpcaoMenu)_menu).GetDisplayName());
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine();
            Console.Write("Digite a opção desejada: ");

            return (EnumOpcaoMenu)Enum.Parse(typeof(EnumOpcaoMenu), Console.ReadLine().ToString().ToUpper());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Opção não existente!");
            return Menu();
        }

    }

}
public enum EnumOpcaoMenu
{
    [Display(Name = "A - Cadastrar Contato")]
    A,
    [Display(Name = "B - Buscar Contato")]
    B,
    [Display(Name = "C - Excluir Contato")]
    C,
    [Display(Name = "D - Mostrar Contatos")]
    D,
    [Display(Name = "S - Sair")]
    S,
}

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum enumValue)
    {
        return enumValue.GetType()
                        .GetMember(enumValue.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()
                        .GetName();
    }
}
