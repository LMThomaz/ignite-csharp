namespace HelloWorld.Aulas.TiposDeDados;

public class Enum
{
  enum NivelDificuldade
  {
    Baixo,
    Medio,
    Alto
  }

  static public void Exemple()
  {
    NivelDificuldade nivel = NivelDificuldade.Medio;
    int nivelInt = (int)nivel;

    switch (nivel)
    {
      case NivelDificuldade.Baixo:
        Console.WriteLine("Nível de dificuldade baixo " + nivelInt);
        break;
      case NivelDificuldade.Medio:
        Console.WriteLine("Nível de dificuldade médio " + nivelInt);
        break;
      case NivelDificuldade.Alto:
        Console.WriteLine("Nível de dificuldade alto " + nivelInt);
        break;
      default:
        Console.WriteLine("Nível de dificuldade não identificado - " + nivelInt);
        break;
    }
  }
}
