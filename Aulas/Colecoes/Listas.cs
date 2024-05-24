namespace HelloWorld.Aulas.Colecoes;

public class Listas
{
  public static void Exemple()
  {
    List<int> inteiros = new List<int>();

    inteiros.Add(1);
    inteiros.Add(2);
    inteiros.Add(3);

    inteiros.Remove(2); // Remove o valor 2
    inteiros.RemoveAt(0); // Remove o valor na posição 0

    Console.WriteLine(inteiros[0]);
    Console.WriteLine(inteiros.Count);

    inteiros.Clear(); // Limpa a lista
  }
}
