namespace Desafios.Classes
{
  public static class Xenlongao
  {

    public static void XenlongaoInit()
    {
      bool repetir = true;
      do
      {
        Console.Write("Digite a quantidade de testes que deseja fazer:");
        var casoDeTeste = Inputs.ValidaInt();
        Xenlongao.EncontrarEsferas(casoDeTeste);

        Inputs.ControleDeRepeticao(ref repetir);
      } while (repetir);
    }


    public static void EncontrarEsferas(int casos)
    {
      for (int i = 0; i < casos; i++)
      {
        Console.Write("Digite a quantidade de esferas: ");
        int esferas = Inputs.ValidaInt();
        Console.WriteLine("Goku só precisa pegar " + (esferas - Math.Floor(Math.Sqrt(esferas))) + " esferas para invocar Xenlongão!");
      }
    }
  }
}