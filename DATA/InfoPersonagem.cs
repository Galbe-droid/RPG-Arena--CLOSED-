using System;
using System.IO;
using System.Collections.Generic;

class InfoPersonagem
{
  public static void Mostragem()
  {
    string opcaoInfo;
    bool listaVazia; 

    if(Listas.jogadores == null)
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
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=========Barracks========");
        Console.ResetColor();

        Console.WriteLine("You wish to... ?\nA - ...view All character.\nB - ...view a specific character\n C - Delete a Character.\nX - ... go back. ");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("===========================");
        Console.ResetColor();

        Console.Write("Option: ");
        do
        {
        opcaoInfo = Console.ReadLine();
        }while(opcaoInfo == String.Empty);

        switch(opcaoInfo)
        {
          case "a":
          case "A":
            Console.Clear();
            TodosJogadores();
            break;

          case "b":
          case "B":
            break;

          case "c":
          case "C":
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

  public static void TodosJogadores()
  {
    foreach(Player p in Listas.jogadores)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("===========================");
      Console.ResetColor();

      Console.WriteLine($"Character ID:{p.IDPlayer}");

      Console.WriteLine($"Character Name:{p.NomePlayer}");
      Console.WriteLine($"Character Experience:{p.Experiencia}");
      
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
}