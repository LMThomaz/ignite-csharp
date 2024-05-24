namespace HelloWorld.Aulas.Colecoes;

public class HashSets
{
  public static void Exemple()
  {
    // HashSet é uma coleção que não permite elementos duplicados
    HashSet<int> set = new HashSet<int>();

    set.Add(1);
    set.Add(2);
    set.Add(1); // Não adiciona o valor 1 novamente

    Console.WriteLine(set.Contains(2)); // True
    Console.WriteLine(set.Count); // 2
  }
}
