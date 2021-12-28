namespace Desafios.Classes
{
  public static class GeradorMegaSena
  {
    public static void MegaSenaInit()
    {
      bool repetir = true;
      do
      {
        Console.WriteLine("Os número da Mega Sena:");
        GerarMegaSena();

        Inputs.ControleDeRepeticao(ref repetir);
      } while (repetir);
    }

    private static void GerarMegaSena()
    {
      int[] numerosGerados = new int[6];

      for (int i = 0; i < 6; i++)
      {
        bool repetir;
        do
        {
          repetir = true;
          Random random = new Random();
          int randomized = random.Next(1, 61);

          if (!(numerosGerados.Contains(randomized)))
          {
            repetir = false;
            numerosGerados[i] = randomized;
          }

        } while (repetir);
      }
      ImprimirArray(numerosGerados);
    }

    public static void ImprimirArray(int[] array)
    {
      var linha = string.Join(", ", array);
      Console.WriteLine(linha);
    }
  }
}