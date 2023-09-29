using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma linha com letras e números:");
        string entrada = Console.ReadLine();

        SepararLetrasNumeros(entrada);
    }

    static void SepararLetrasNumeros(string texto)
    {
        string padraoLetras = "[A-Za-z]";
        string padraoNumeros = "[0-9]";

        string letras = string.Join(",", Regex.Matches(texto,padraoLetras));
        string numeros = string.Join(",", Regex.Matches(texto, padraoNumeros));

        Console.WriteLine("Letras: " +letras);
        Console.WriteLine("Número: " + numeros);
        Console.ReadLine();
    }
}