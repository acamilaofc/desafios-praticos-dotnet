namespace Desafios.Classes
{
  public static class Xenlongao
  {

    public static void XenlongaoInit()
    {
      bool repetir = true;

      do
      {
        Console.WriteLine("Digite a quantidade de testes que deseja fazer:");
        var casoDeTeste = Inputs.ValidaInt();
        Xenlongao.EncontrarEsferas(ref casoDeTeste);

        Inputs.ControleDeRepeticao(ref repetir);
      } while (repetir);
    }
    public static int QntDivisores(int numero)
    {
      int resultado = 1;
      int n = numero;
      int fatorando = 2;
      List<int> exps = new List<int>();

      while (n > 1)
      {
        if (n % fatorando == 0)
        {
          n /= fatorando;
          resultado++;
          if (n == 1)
          {
            exps.Add(resultado);
          }
        }
        else if (n % fatorando != 0 && resultado == 1)
        {
          fatorando++;
        }
        else
        {
          fatorando++;
          exps.Add(resultado);
          resultado = 1;
        }

      }

      resultado = 1;

      foreach (int i in exps)
      {
        resultado *= i;
      }
      return resultado;
    }


    public static void EncontrarEsferas(ref int casos)
    {
      while (casos > 0)
      {
        Console.Write("Insira o próximo teste: ");
        int esferas = Inputs.ValidaInt();
        int resultado = 0;

        for (int i = 2; i <= esferas; i++)
        {
          int divisores = QntDivisores(i);
          if (divisores % 2 == 0)
            resultado++;
        }
        Console.WriteLine($"Resultado: {resultado}");
        casos--;
      }
    }
  }
}