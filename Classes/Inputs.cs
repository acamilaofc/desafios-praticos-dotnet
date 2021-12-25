namespace Desafios.Classes
{
  public static class Inputs
  {

    public static void ControleDeRepeticao(ref bool repetir)
    {
      bool thisRepetir = true;

      while (thisRepetir)
      {
        Console.WriteLine("Deseja repetir? (Y/N)" +
          Environment.NewLine + "Y - Sim" + Environment.NewLine + "N - Não");

        string opcao = Console.ReadLine().ToUpper();

        if (opcao == "N")
        {
          repetir = false;
          thisRepetir = false;
        }
        else if (opcao == "Y")
        {
          repetir = true;
          thisRepetir = false;
        }
        else
        {
          Console.WriteLine("Digite Y para sim e N para não!");
        }
      }
    }
    public static string ValidaOpcao()
    {
      string input = "";
      bool repetir = true;

      while (repetir)
      {
        input = Console.ReadLine().ToUpper();

        if (input.Length >= 1)
          repetir = false;
      }
      return input;
    }

    public static int ValidaInt()
    {
      int input = 0;
      bool repetir = true;

      while (repetir)
      {
        try
        {
          input = int.Parse(Console.ReadLine());
          repetir = false;
        }
        catch (FormatException)
        {
          Console.WriteLine("Insira apenas um valor inteiro!");
        }
      }

      return input;
    }

    public static double ValidaDouble()
    {
      double input = 0.0;
      bool repetir = true;

      while (repetir)
      {
        try
        {
          input = double.Parse(Console.ReadLine());
          repetir = false;
        }
        catch (FormatException)
        {
          Console.WriteLine("Insira apenas um valor real!");
        }
      }
      return input;
    }
  }
}