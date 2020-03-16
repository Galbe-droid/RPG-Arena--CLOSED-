using System;
using System.IO;
using System.Collections.Generic;

class InfoPersonagem
{
  public static void Mostragem()
  {
    string opcaoInfo;
    bool listaVazia; 

    if(Listas.jogadores.Count == 0)
    {
      listaVazia = true;
    }
    else
    {
      listaVazia = false;
    }

    while(true)
    {
      if(listaVazia != true)
      {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=========Barracks========");
        Console.ResetColor();

        Console.WriteLine("You wish to... ?\nA - ...view All character.\nB - ...view a specific character\nC - ...delete a Character.\nX - ... go back. ");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("===========================");
        Console.ResetColor();

        Console.Write("Option: ");
        do
        {
        opcaoInfo = Console.ReadLine().ToUpper();
        }while(opcaoInfo == String.Empty);

        if(opcaoInfo == "X")
        {
          break;
        }

        switch(opcaoInfo)
        {
          case "A":
            Console.Clear();
            TodosJogadores();
            break;

          case "B":
            Console.Clear();
            JogadorEspecifico();
            break;

          case "C":
            Console.Clear();
            DeletarJogador();
            break;

          default:
            Console.Clear();
            break;
        }
      }
      else
      {
        Console.WriteLine("The barracks are empty, try creating a character first.");
        Console.ReadLine();
        Console.Clear();
        break;
      }
      break;
    }
  }
  //Lista mostra todos os jogadores: Funcionando
  public static void TodosJogadores()
  {
    foreach(Player p in Listas.jogadores)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("===========================");
      Console.ResetColor();

      Console.WriteLine($"Character ID: {p.IDPlayer}");

      Console.WriteLine($"Character Name: {p.NomePlayer}");
      Console.WriteLine($"Character Experience: {p.Experiencia}");
      
      Console.WriteLine();

      Console.WriteLine($"Max HP: {p.PontoDeVida}    Max MP: {p.PontoDeMana}");

      Console.WriteLine();

      Console.WriteLine($"Str:{p.Forca} / Dex:{p.Destreza} / Int: {p.Inteligencia} / Vit: {p.Vitalidade}");

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("===========================");
      Console.ResetColor();
    }
    Console.WriteLine("Press Any key to exit.");
    Console.ReadLine();
    Console.Clear();
  }

  //Lista mostra 1 jogador em especifico: Funcionando
  public static void JogadorEspecifico()
  {
    string nome;
    List<string> lista_de_personagens = new List<string>();
    Console.WriteLine("Characters resting at barracks: \n");
    foreach(Player p in Listas.jogadores)
    {
      lista_de_personagens.Add(p.NomePlayer);
      Console.WriteLine($"> {p.NomePlayer}");
      Console.WriteLine();
    }
    while(true)
    {
      Console.Write("Choose a character: ");
      nome = Console.ReadLine().ToUpper();
      Console.WriteLine();
      foreach(Player p in Listas.jogadores)
      {
        if(nome == p.NomePlayer.ToUpper())
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("===========================");
          Console.ResetColor();

          Console.WriteLine($"Character ID: {p.IDPlayer}");

          Console.WriteLine($"Character Name: {p.NomePlayer}");
          Console.WriteLine($"Character Experience: {p.Experiencia}");
          
          Console.WriteLine();

          Console.WriteLine($"Max HP: {p.PontoDeVida}    Max MP: {p.PontoDeMana}");

          Console.WriteLine();

          Console.WriteLine($"Str:{p.Forca} / Dex:{p.Destreza} / Int: {p.Inteligencia} / Vit: {p.Vitalidade}");

          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("===========================");
          Console.ResetColor(); 
          break;
        }
      }
      break;
    }
    Console.WriteLine("Press Any key to exit.");
    Console.ReadLine();
    Console.Clear();
  }

  //Lista para deletar um jogador: Funcionado Obrigado Stackoverflow 
  public static void DeletarJogador()
  {
    int ID;
    Console.WriteLine("Characters resting at barracks: \n");
    foreach(Player p in Listas.jogadores)
    {
      Console.WriteLine($">Name: {p.NomePlayer}           ID: {p.IDPlayer}");
      Console.WriteLine();
    }
    while(true)
    {
      Console.Write("Choose a character to delete, by ID: ");
      ID = Convert.ToInt32(Console.ReadLine());

      for(int i = 0 ; i <= Listas.jogadores.Count; i++)
      {
        if(ID == Listas.jogadores[i].IDPlayer)
        {
          Listas.jogadores.RemoveAt(i);
        }
      }
      Console.Clear();
    }
  }
}