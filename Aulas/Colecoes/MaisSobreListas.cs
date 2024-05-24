namespace HelloWorld.Aulas.Colecoes;

public class MaisSobreListas
{
  public static void Exemple()
  {
    List<string> strings = new List<string>();

    strings.Add("Hello");
    strings.Add("World");

    Console.WriteLine(strings.Contains("Hello")); // True

    string resultado = string.Join(" ", strings);

    Console.WriteLine(resultado); // Hello World

    List<int> ints = new List<int> { 1, 2, 3, 4, 5 };

    Console.WriteLine(ints.IndexOf(3)); // 2

    List<object> objectos = new List<object> { 1, "Hello", 3.14 };

    Console.WriteLine(objectos[1]); // Hello
  }
}
