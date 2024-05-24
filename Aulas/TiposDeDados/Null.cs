namespace HelloWorld.Aulas.TiposDeDados;

public class Null
{
  public static void Exemple()
  {
    // O Null é um valor que representa a ausência de valor
    //    e é utilizado para inicializar variáveis que não possuem valor
    string? nome = null;
    int? meuNumero = null;

    // O Null é utilizado para verificar se uma variável possui valor
    if (nome == null)
    {
      Console.WriteLine("Nome não informado");
    }

    if (meuNumero.HasValue)
    {
      Console.WriteLine("Número informado");
    }
    else
    {
      Console.WriteLine("Número não informado");
    }
  }
}
