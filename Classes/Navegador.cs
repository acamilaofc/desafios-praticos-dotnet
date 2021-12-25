namespace Desafios.Classes
{
  public class Navegador
  {
    private void PrintMenu()
    {
      Console.WriteLine();
      Console.WriteLine("ESCOLHA QUAL DESAFIO DESEJA RODAR:");
      Console.WriteLine("1 - Xenlongão");
      Console.WriteLine("2 - Calcular média");


      Console.WriteLine("C - Limpar tela");
      Console.WriteLine("X - Encerrar aplicação");
      Console.WriteLine();
    }
    public void InitMenu()
    {
      while (true)
      {
        PrintMenu();
        string opcao = Inputs.ValidaOpcao();

        switch (opcao)
        {
          case "1":
            Xenlongao.XenlongaoInit();
            break;

          case "2":
            Media.MediaInit();
            break;
          case "C":
            Console.Clear();
            break;
          case "X":
            Environment.Exit(0);
            break;
          default:
            Console.WriteLine("Opção não encontrada, digite apenas o indíce das opções listadas acima.");
            break;
        }
      }
    }
  }
}