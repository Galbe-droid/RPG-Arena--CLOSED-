using System;
using System.IO;
using System.Collections.Generic;

public class Criar
{
  public static void Personagem()
  {  
    string nome;

    float experiencia = 0;

    float forca = 0;
    float forcaTotal = 0;

    float destreza = 0;
    float destrezaTotal = 0;

    float inteligencia = 0;
    float inteligenciaTotal = 0;

    float vitalidade = 0;
    float vitalidadeTotal = 0;

    float atributo = 24;
    float totalAtributos = 0;
    

    bool temArma = false;
    bool temArmadura = false; 

    string opcao;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("=========Character Creation========");
    Console.ResetColor();

    Console.WriteLine("You want to be called ?");
    Console.Write("Name: ");
    nome = Console.ReadLine();

    while(true)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"========={nome}========");
      Console.ResetColor();

      float atributosGastos = forcaTotal + destrezaTotal + inteligenciaTotal + vitalidadeTotal;

      totalAtributos = totalAtributos + atributosGastos;


      if(atributosGastos <= atributo)
      {
        Console.WriteLine($"You have {atributo - atributosGastos} point(s) to spend in your attributes.");
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Your character has {atributo - atributosGastos} point(s) in excess.");
        Console.ResetColor();
      }
      
      Console.WriteLine("To select an attribute you need to type the FIRST letter of that attribute.\nTo remove points put the minus sing.\nFinishing the character you can press 'x' and enter to proceed.");

      Console.WriteLine("==============================");

      if(forcaTotal == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Strength({forcaTotal})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Strength({forcaTotal})");
      }

      if(destrezaTotal == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Dexterity({destrezaTotal})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Dexterity({destrezaTotal})");
      }

      if(inteligenciaTotal == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Intelligence({inteligenciaTotal})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Intelligence({inteligenciaTotal})");
      }

      if(vitalidadeTotal == 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"Vitality({vitalidadeTotal})");
        Console.ResetColor();
      }
      else
      {
        Console.WriteLine($"Vitality({vitalidadeTotal})");
      }

      Console.WriteLine("==============================");

      Console.Write("Option: ");
      do
      {
        opcao = Console.ReadLine();
      }while(opcao == String.Empty);
      
      switch(opcao)
      {
        case "s":
        case "S":
          forca = ModificarAtributos.Forca(forca);

          if(forcaTotal < 0)
          { 
            Console.WriteLine("Negative total attribute value.");
            Console.ReadLine();
            forca = 0;
          } 

          forcaTotal = forca + forcaTotal;
          break;

        case "d":
        case "D":
          destreza = ModificarAtributos.Destreza(destreza);

          if(destrezaTotal < 0)
          {
            Console.WriteLine("Negative total attribute value.");
            Console.ReadLine();
            destreza = 0;
          }

          destrezaTotal = destreza + destrezaTotal;
          break;

        case "i":
        case "I":
          inteligencia = ModificarAtributos.Inteligencia(inteligencia);

          if(inteligenciaTotal < 0)
          {
            Console.WriteLine("Negative total attribute value.");
            Console.ReadLine();
            inteligencia = 0;
          }

          inteligenciaTotal = inteligencia + inteligenciaTotal;
          break;

        case "v":
        case "V":
          vitalidade = ModificarAtributos.Vitalidade(vitalidade);

          if(vitalidadeTotal < 0)
          {
            Console.WriteLine("Negative total attribute value.");
            Console.ReadLine();
            vitalidade = 0;
          }

          vitalidadeTotal = vitalidade + vitalidadeTotal;
          break;

        case "x":
        case "X":
          Verificacao(atributo, atributosGastos, totalAtributos, forca, destreza, inteligencia, vitalidade);
          break;

        default:
          break;
      }
      if(opcao == "x" || opcao == "X")
      {
        break;
      }
    }  

    float PdVTotal = vitalidade * 10 + 10;
    float PdMTotal = inteligencia * 5 + 10;

    Listas.RepositorioJogador(nome, experiencia, PdVTotal, PdMTotal, atributo, forca, destreza, inteligencia, vitalidade, temArma, temArmadura);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{nome} was now born into the arena.");
    Console.ResetColor();
    Console.ReadLine();
    Console.Clear();
  }

  public static void Verificacao(float atributo2, float atributosGastos2, float totalAtributo2, float forcaFinal, float destrezaFinal, float inteligenciaFinal, float vitalidadeFinal) 
  {
    if(atributo2 != atributosGastos2)
    {
      if(atributo2 > atributosGastos2)
      {
        Console.WriteLine("Nem todos os pontos foram gastos !");
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Existem pontos excedentes");
        Console.ReadLine();
      }
    }

    if(atributo2 == atributosGastos2)
    {
      if(forcaFinal == 0 || destrezaFinal == 0 || inteligenciaFinal == 0 || vitalidadeFinal == 0)
      {
        Console.WriteLine("There is some atributes with 0 points invested.");
        Console.ReadLine();
      }
    }
  }
}
