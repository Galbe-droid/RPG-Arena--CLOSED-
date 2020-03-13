using System;
using System.IO;
using System.Collections.Generic;

class MenuPrincipal
{
  public static void Escolhas(string escolha)
  {
    switch(escolha)
    {
      case "a":
      case "A":
        Criar.Personagem();
        break;

      case "l":
      case "L":
        if(Directory.GetFiles($@"DATA/PersonagensSalvos").Length == 0)
        {
        Console.WriteLine("There is no caracters saved, press any key to go back.");
        Console.ReadKey();
        Console.Clear();
        break;
        }
        else
        {
          Console.Write("Under Work.");
          Console.ReadKey();
          Console.Clear();
          break;
        }

      case "c":
      case "C":
        InfoPersonagem.Mostragem();
        break;

       case "I":
       case "i":
        break; 
      
      default:
        Console.WriteLine("Invalid option, try again!");
        Console.Clear();
        break;
    }
  }
}
