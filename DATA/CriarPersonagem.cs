using System;
using System.IO;
using System.Collections.Generic;

public class Criar
{
  public static void Personagem()
  {

    int ID;
    string nome;

    float experiencia = 0;

    float forca = 0;

    float destreza = 0;
    float destrezaModificar;

    float inteligencia = 0;
    float inteligenciaModificar;

    float vitalidade = 0;
    float vitalidadeModificar;

    float atributo = 24;
    

    bool temArma = false;
    bool temArmadura = true; 

    string opcao;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("=========Character Creation========");
    Console.ResetColor();

    Console.WriteLine("You want to be called ?");
    Console.Write("Name: ");
    nome = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("===================================");
      
    Console.ResetColor();
    while(true)
    {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"========={nome}========");
    Console.ResetColor();

    float atributosGastos = forca + destreza + inteligencia + vitalidade;
   
      Console.WriteLine($"You have {atributo - atributosGastos} to spend in your attributes.\nTo select an attribute you need to type the FIRST letter of that attribute.\nTo remove points put the minus sing.\nFinishing the character you can press x and enter to proceed.");

      Console.WriteLine("==============================");

      if(forca == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Strength({forca})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Strength({forca})");
      }

      if(destreza == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Dexterity({destreza})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Dexterity({destreza})");
      }

      if(inteligencia == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Intelligence({inteligencia})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Intelligence({inteligencia})");
      }

      if(vitalidade == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Vitality({vitalidade})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Vitality({vitalidade})");
      }

      Console.WriteLine("==============================");

      Console.Write("Option: ");
      do
      {
        opcao = Console.ReadLine();
      }while(opcao == String.Empty && opcao != "s" && opcao != "S" && opcao != "d" && opcao != "D" && opcao != "i" && opcao != "I" && opcao != "v" && opcao != "V" && opcao != "x" && opcao != "X");
      
      switch(opcao)
      {
        case "s":
        case "S":
          forca = ModificarAtributos.Forca(forca);
          break;
      }
      
      
      //Problemas(atributo, atributosGastos);
    }   
  }

  public static void Problemas(float atributo2, float atributosGastos2)
  {
    if(atributo2 != atributosGastos2)
    {
      if(atributo2 > atributosGastos2)
      {
        Console.WriteLine("Nem todos os pontos foram gastos !");
      }
      else
      {
        Console.WriteLine("Existem pontos excedentes");
      }
    }
  }
}

class ModificarAtributos
{
  public static float Forca(float forca2)
  {
    float forcaModificar2; 
    Console.WriteLine("===Strength===");
    Console.WriteLine("Discription TBW");

    Console.WriteLine("Points: ");
    forcaModificar2 = Convert.ToSingle(Console.ReadLine());

    if(forca2 > 0)
    {
      Console.WriteLine("Negative total attribute value.");
      forcaModificar2 = 0;
    }

    forca2 = forcaModificar2 + forca2;
    return forca2;
  }
} 