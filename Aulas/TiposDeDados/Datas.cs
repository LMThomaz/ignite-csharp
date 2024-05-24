using System.Globalization;

namespace HelloWorld.Aulas.TiposDeDados;

public class Datas
{
  static public void Example()
  {
    DateOnly dia = new DateOnly(2024, 5, 23);

    string diaEmTexto = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

    DateTime dataHora = new DateTime(2024, 5, 23, 14, 30, 0);

    string dataHoraEmTexto = dataHora.ToString("dd/MMMM/yyyy HH:mm:ss", new CultureInfo("pt-BR"));

    DateTime hoje = DateTime.UtcNow;

    DateTime novaData = hoje.AddDays(7);

    Console.WriteLine("diaEmTexto -> " + diaEmTexto);
    Console.WriteLine("dataHoraEmTexto -> " + dataHoraEmTexto);
  }
}
