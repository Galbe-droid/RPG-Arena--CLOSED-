using System;
using System.IO;
using System.Collections.Generic;

class EntradaArena
{
  public static void VisaoPersonagem(int IDP)
  {
    float danoP = 0;
    string opcaoArena;
    string dormir; 
    int IDM = 0;

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
        else if(opcaoArena == "R")
        {
          Console.WriteLine("Sleep will make the cages reset do you want that [Y/N]");
          Console.Write("Choice: ");
          dormir = Console.ReadLine().ToUpper();
          
          if(dormir == "Y")
          {
            Console.Clear();
            IDM = 1;
          }
        }
        else if(opcaoArena != "X" || opcaoArena != "R")
        {
          EscolhaArena(opcaoArena, IDP, IDM);
          IDM = Retorno(IDM);
        }

        
        if(IDM != 4)
        {
        Console.Clear();
        Console.WriteLine("A day has passed.");
        Console.ReadLine();
        dias++;
        Listas.monstroDia.Clear();
        break;
        }
      }
      
      if(opcaoArena == "Y"){Console.Clear(); break;}
    }
  }

  public static void EscolhaArena(string opcao, int IDP, int IDM)
  {
    switch(opcao)
    {
      case"A":
        Console.WriteLine("This are the monsters we have for today [Choose 4 if you want to go back]:");
        foreach(Monstro m in Listas.monstroDia)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"============Cage{m.IDMonstro}==========");
          Console.ResetColor();

          Console.WriteLine($"{m.Nome}, {m.Nivel}, {m.Rank}");

          Console.ForegroundColor = ConsoleColor.Red; 
          Console.WriteLine("===========================");
          Console.ResetColor();
        }
       
        IDM = Convert.ToInt32(Console.ReadLine());
        if(IDM == 4)
        {
          Retorno(IDM);
          break;
        }
        else if(IDM == Listas.monstroDia[IDM-1].IDMonstro)
        {
          HUD.GerarMonstro(IDM);
        }
        
        Combate.CombateTurno(IDP, IDM);
        break;

      case"S":
        Console.WriteLine("Under Development.");
        Console.ReadLine();
        break;
    }
  }

  public static int Retorno (int IDM)
  {
    IDM = 4;
    return IDM;
  }
}

