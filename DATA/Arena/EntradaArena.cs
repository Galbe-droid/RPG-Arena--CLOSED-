using System;
using System.IO;
using System.Collections.Generic;

class EntradaArena
{
  public static void VisaoPersonagem(string nomeP, float expP,float pdvP, float pdmP, float forP, float desP, float intP, float vitP, bool armaP, bool armaduraP)
  {
    float danoP = 0;
    float manaGastaP = 0;
    string opcaoArena; 
     

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

        HUD.InformacoesGerais(nomeP, expP, forP, desP, intP, vitP);
    
        Console.WriteLine();

        HUD.VidaMana(pdvP, pdmP, danoP, manaGastaP);
    
        Console.WriteLine();
        Console.WriteLine();

        HUD.Equipamentos(armaP, armaduraP);

        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine("===========================");
        Console.ResetColor();

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

        EscolhaArena(opcaoArena);
      }
      
      if(opcaoArena == "Y"){Console.Clear(); break;}
    }
  }

  public static void EscolhaArena(string opcao)
  {
    switch(opcao)
    {
      case"A":
        Console.WriteLine("This are the monsters we have for today:");
        foreach(Monstro m in Listas.monstroDia)
        {
          Console.WriteLine($"{m.Nome}, {m.Nivel}, {m.Rank}, {m.Categoria} , {m.PontosDeVida}, {m.PontosDeMana}, {m.Forca}, {m.Destreza}, {m.Inteligencia}, {m.Vitalidade}");
        }
        Console.ReadLine();
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