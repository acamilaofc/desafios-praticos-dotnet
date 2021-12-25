namespace Desafios.Classes
{
  public static class Media
  {
    public static void MediaInit()
    {
      bool repetir = true;

      do
      {
        tirarMedia();
        Inputs.ControleDeRepeticao(ref repetir);


      } while (repetir);
    }


    public static void tirarMedia()
    {
      Console.Write(Environment.NewLine + "CALCULAR MÉDIA" + Environment.NewLine + "Digite a quantidade de notas que deseja inserir: ");
      int qntDeNotas = Inputs.ValidaInt();
      double somaDasNotas = 0.0;
      int pesoTotal = 0;

      for (int i = 0; i < qntDeNotas; i++)
      {
        Console.Write("Inserir nota: ");
        double notaAtual = Inputs.ValidaDouble();
        Console.Write("Insirir peso da nota: ");
        int pesoDaNota = Inputs.ValidaInt();
        somaDasNotas += (notaAtual * pesoDaNota);
        pesoTotal += pesoDaNota;
      }

      double media = somaDasNotas / pesoTotal;
      Console.WriteLine("O alunx obteve a seguinte média: " + Math.Round(media, 2));



      if (media >= 7.0)
        Console.WriteLine("Alunx aprovadx!");
      else if (media >= 5.0)
        MediaRecuperacao(media);
      else
        Console.WriteLine("Alunx reprovadx");
    }

    public static void MediaRecuperacao(double notaObtida)
    {
      Console.WriteLine("Alunx ficou de recuperação!" + Environment.NewLine +
      "Deseja aplicar a prova de recuperação?" + Environment.NewLine + "Y - Sim"
      + Environment.NewLine + "N - Não");

      bool repetir = true;

      while (repetir)
      {
        string opcao = Inputs.ValidaOpcao();
        switch (opcao)
        {
          case "Y":
            Console.Write("Prova aplicada, digite o valor obtido na prova: ");
            double prova = Inputs.ValidaDouble();
            double media = (prova + notaObtida) / 2;
            Console.WriteLine("Média final do alunx: " + Math.Round(media, 1));

            if (media >= 5.0)
              Console.WriteLine("Alunx aprovadx!");
            else
              Console.WriteLine("Alunx reprovadx");

            repetir = false;

            break;
          case "N":
            Console.WriteLine("A prova não será aplicada!");
            repetir = false;
            break;
          default:
            Console.WriteLine("Digite Y para sim e N para não!");
            break;
        }
      }
    }
  }
}