using System;
using System.IO;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.ReadKey();
    Console.Clear();

    string opcao;
    while(true)
    {
      bool existePersonagem;

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("     RPG Arena - ALPHA");  
      Console.ResetColor();

      Console.WriteLine("===========================");
      Console.WriteLine("A - New Character ");

      existePersonagem = Confirmacao.ExistePersonagem();
      if(!existePersonagem)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("L - Load Character ");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine("L - Load Character ");
      }

      Console.WriteLine("C - Characters ");
      Console.WriteLine("I - Information ");

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("X - Exit");
      Console.ResetColor();
      Console.WriteLine("===========================");

      Console.Write("Option: ");
      opcao = Console.ReadLine();

      if(opcao == "X" || opcao == "x")
      {
        Console.Clear();
        Console.WriteLine("Program Closed");
        break;
      }
      else
      {
        MenuPrincipal.Escolhas(opcao);
      }
    }
  }
}