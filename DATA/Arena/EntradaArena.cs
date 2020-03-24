using System;
using System.IO;
using System.Collections.Generic;

class EntradaArena
{
  public static void VisaoPersonagem(int IDP)
  {
    float danoP = 0;
    string opcaoArena; 
    int IDM  = 0;

    while(true)
    {
      int dias = 1;
      Selecao.SelecionarMonstro();
      while(true)
      {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"   Arena Entrace  Day:{dias} ");  
        Console.WriteLine($"===========================");
        Console.ResetColor();

        CombateHUD.PlayerHUD(IDP, danoP);

        Console.WriteLine("\n Where to go ?");

        Console.WriteLine("A - Pick a monster to fight\nS - Go to the Arena Shops\nR - Go to your Room");
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine("X - Go back to main menu.");
        Console.ResetColor();

        Console.Write(">>>Option: ");
        do
        {
          opcaoArena = Console.ReadLine().ToUpper();
        }while(opcaoArena == String.Empty);

        if(opcaoArena == "X")
        {
          Console.Write("Are you sure that you want to exit ? [Y/N]: ");
          {
            opcaoArena = Console.ReadLine().ToUpper();
          }while(opcaoArena == String.Empty);

          if(opcaoArena == "Y"){Console.Clear(); break;}

        } 

        EscolhaArena(opcaoArena, IDP, IDM);
      }
      
      if(opcaoArena == "Y"){Console.Clear(); break;}
    }
  }

  public static void EscolhaArena(string opcao, int IDP, int IDM)
  {
    switch(opcao)
    {
      case"A":
        Console.WriteLine("This are the monsters we have for today:");
        foreach(Monstro m in Listas.monstroDia)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"============Cage{m.IDMonstro}===========");
          Console.ResetColor();

          Console.WriteLine($"{m.Nome}, {m.Nivel}, {m.Rank}");

          Console.ForegroundColor = ConsoleColor.Red; 
          Console.WriteLine("===========================");
          Console.ResetColor();
        }
       
        IDM = Convert.ToInt32(Console.ReadLine());
        if(IDM == Listas.monstroDia[IDM-1].IDMonstro)
        {
          HUD.GerarMonstro(IDM);
        }
        Combate.CombateTurno(IDP, IDM);
        break;

      case"S":
        Console.WriteLine("Under Development.");
        Console.ReadLine();
        break;

      case"R":
        Console.WriteLine("Not Ready yet.");
        Console.ReadLine();
        break;
    }
  }
}