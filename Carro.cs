namespace HelloWorld;

class Carro
{
  public void Ligar()
  {
    Console.WriteLine("Carro ligado");
    Acelerar();
  }

  public void Desligar()
  {
    Console.WriteLine("Carro desligado");
  }

  private void Acelerar()
  {
    Console.WriteLine("Carro acelerando");
  }

  internal void Frear()
  {
    Console.WriteLine("Carro freando");
  }

}
