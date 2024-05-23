namespace HelloWorld.Aulas;

public class Objetos
{
  public static void Exemple()
  {
    // Similar ao var, porém, o object é um tipo mais genérico
    //    pode receber qualquer tipo de objeto, porém não é recomendado e não faz inferência de tipo
    object minhaVariavel = new Carro();

  }
}
