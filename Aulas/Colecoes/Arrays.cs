namespace HelloWorld.Aulas.Colecoes;

public class Arrays
{
  public static void Exemple()
  {
    int[] inteiros = new int[10];

    inteiros[0] = 1;

    Console.WriteLine(inteiros.Length);
    Console.WriteLine(inteiros[0]);

    int[,] matriz = new int[2, 2];

    matriz[0, 0] = 1;
    matriz[0, 1] = 2;
    matriz[1, 0] = 3;
    matriz[1, 1] = 4;
  }
}
