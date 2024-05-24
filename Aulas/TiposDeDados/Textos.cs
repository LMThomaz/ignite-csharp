using System.Text;

namespace HelloWorld.Aulas.TiposDeDados;

public class Textos
{
  public static void Escrever()
  {
    string texto1 = "Primeira frase.";
    string texto2 = "Segunda frase.";

    string paragrafo = texto1 + " " + 7 + " " + true + " " + texto2;
    string paragrafoInterpolado = $"{texto1} {7} {true} {texto2}";

    // Em questão de performance, o StringBuilder é mais eficiente
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(texto1);
    stringBuilder.Append(" ");
    stringBuilder.Append(7);
    stringBuilder.Append(" ");
    stringBuilder.Append(true);
    stringBuilder.Append(" ");
    stringBuilder.Append(texto2);
    string paragrafoBuilder = stringBuilder.ToString();

    string caminho = "C:\\program files\\arquivo.txt";
    string caminhoSimplificado = @"C:\program files\arquivo.txt";

    Console.WriteLine(paragrafo);
    Console.WriteLine(paragrafoInterpolado);

    string texto = "O usuário {0} digitou o valor {1}";
    string resultado = string.Format(texto, "João", 18);
    Console.WriteLine(resultado);
  }
}
