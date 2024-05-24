namespace HelloWorld.Aulas.Colecoes;

public class Dicionarios
{
  public static void Exemple()
  {
    Dictionary<int, string> dicionario = new Dictionary<int, string>();

    dicionario.Add(1, "Hello");
    dicionario.Add(2, "World");

    bool contem = dicionario.ContainsKey(1);
    bool contemValor = dicionario.ContainsValue("World");

    Console.WriteLine(dicionario[1]); // Hello
    Console.WriteLine(dicionario[2]); // World
  }
}
