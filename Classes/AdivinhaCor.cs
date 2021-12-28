namespace Desafios.Classes
{
  public static class AdivinhaCor
  {
    public static void AdivinhaCorInit()
    {
      bool repetir = true;

      do
      {
        Console.WriteLine("JOGO DE ADIVINHAR NÚMERO");
        Console.Write("Digite o valor mínimo: ");
        int min = Inputs.ValidaInt();
        Console.Write("Digite o valor máximo: ");
        int max = Inputs.ValidaInt();
        Console.Write("Digite a quantidade de chances que terá para adivinhar: ");
        int chutes = Inputs.ValidaInt();

        bool validar = ValidaLimites(min, max, ref repetir);

        if (validar)
          AdivinhaCorGame(min, max, chutes);

        Inputs.ControleDeRepeticao(ref repetir);

      } while (repetir);
    }


    public static void AdivinhaCorGame(int numeroMin, int numeroMax, int chutes)
    {
      Random aleatorio = new Random();
      int gerado = aleatorio.Next(numeroMin, numeroMax + 1);
      List<int> palpites = new List<int>();
      bool acertou = false;

      for (int i = 0; i < chutes; i++)
      {
        Console.WriteLine("Chutes restantes: " + (chutes - i));
        if (palpites.Count != 0)
          MostraPalpites(palpites);

        Console.Write("Digite um palpite: ");
        int guess = Inputs.ValidaInt();
        palpites.Add(guess);


        if (guess > gerado)
        {
          Console.WriteLine("Palpite maior que número gerado.");
        }
        else if (guess < gerado)
        {
          Console.WriteLine("Palpite menor que número gerado.");
        }
        else
        {
          Console.WriteLine("Parabéns, você adivinhou o número");
          acertou = true;
        }

        Console.WriteLine();
      }
      if (!acertou)
      {
        Console.WriteLine("Game Over! Você não conseguiu acertar e suas chances acabaram." +
        Environment.NewLine + "O número certo era: " + gerado);
      }
    }
    public static void MostraPalpites(List<int> palpites)
    {
      string linha = string.Join(", ", palpites);
      Console.WriteLine("Palpites anteriores: " + linha + ".");
    }

    public static bool ValidaLimites(int numeroMin, int numeroMax, ref bool repetir)
    {
      if (numeroMin > numeroMax)
      {
        Console.WriteLine("Erro: O número máximo deve ser maior que o número mínimo, tente novamente!");
        repetir = false;
        return false;
      }
      return true;
    }
  }
}