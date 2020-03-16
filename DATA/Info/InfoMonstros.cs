using System;
using System.IO;
using System.Collections.Generic;

class InfoMonstros
{
  public static void Bestiario()
  {
    string opcao;

    while(true)
    {
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("=========Bestiary========");
      Console.ResetColor();

      Console.WriteLine("You want to...\nA - ... see all monsters.\nB - ... see a specific monster.\nX - ... to go back.");
      Console.Write(">>> Option: ");
      do
      {
      opcao = Console.ReadLine().ToUpper();
      }while(opcao == String.Empty);

      if(opcao == "X")
      {
        Console.Clear();
        break;
      }

      switch(opcao)
      {
        case"A":
          TodosMonstros();
          break;

        case"B":
          MonstroEspecifico();
          break;

        default:
          Console.Clear();
          break;
      }
    }
  } 

  public static void TodosMonstros()
  {
    foreach(Monstro m in Listas.monstro)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("===========================");
      Console.ResetColor();

      Console.WriteLine($"ID: {m.IDMonstro}");
      Console.WriteLine($"Name: {m.Nome}\n");
      
      Console.WriteLine($"Category: {m.Categoria}\n");
      Console.WriteLine($"Initial Rank: {m.Rank}");
      Console.WriteLine($"Initial Level: {m.Nivel}\n");

      Console.WriteLine($"Max HP: {m.PontosDeVida}    Max MP: {m.PontosDeMana}\n");

      Console.WriteLine($"Str:{m.Forca} / Dex:{m.Destreza} / Int: {m.Inteligencia} / Vit: {m.Vitalidade}");

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("===========================");
      Console.ResetColor();
    }
    Console.WriteLine("Press Any key to exit.");
    Console.ReadLine();
    Console.Clear();
  }

  public static void MonstroEspecifico()
  {
    Console.Clear();
    string nome;
    foreach(Monstro m in Listas.monstro)
    {
      Console.WriteLine($"Nome:{m.Nome}     ID:{m.IDMonstro}");
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("===========================");
    Console.ResetColor();
    
    while(true)
    {
      Console.WriteLine("Choose a monster by its NAME.");
      Console.Write("Name: ");
      nome = Console.ReadLine().ToUpper();

      foreach(Monstro m in Listas.monstro)
      {
        if(nome == m.Nome.ToUpper())
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("===========================");
          Console.ResetColor();

          Console.WriteLine($"ID: {m.IDMonstro}");
          Console.WriteLine($"Name: {m.Nome}\n");
      
          Console.WriteLine($"Category: {m.Categoria}\n");
          Console.WriteLine($"Initial Rank: {m.Rank}");
          Console.WriteLine($"Initial Level: {m.Nivel}\n");

          Console.WriteLine($"Max HP: {m.PontosDeVida}    Max MP: {m.PontosDeMana}\n");

          Console.WriteLine($"Str:{m.Forca} / Dex:{m.Destreza} / Int: {m.Inteligencia} / Vit: {m.Vitalidade}");

          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("===========================");
          Console.ResetColor();

          Console.WriteLine("Press Any key to exit.");
          Console.ReadLine();
          Console.Clear();
          break;
        }
      }
      break;
    }
  }
}