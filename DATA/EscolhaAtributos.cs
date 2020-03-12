using System;
using System.IO;
using System.Collections.Generic;

class ModificarAtributos
{
  public static float Forca(float forca2)
  { 
    Console.WriteLine("===Strength===");
    Console.WriteLine("Discription TBW");

    Console.Write("Points: ");
    forca2 = Convert.ToSingle(Console.ReadLine());

    return forca2;
  }

  public static float Destreza(float destreza2)
  {
    Console.WriteLine("===Dexterity===");
    Console.WriteLine("Discription TBW");

    Console.Write("Points: ");
    destreza2 = Convert.ToSingle(Console.ReadLine());

    return destreza2;
  }

  public static float Inteligencia(float inteligencia2)
  {
    Console.WriteLine("===Intelligence===");
    Console.WriteLine("Discription TBW");

    Console.Write("Points: ");
    inteligencia2 = Convert.ToSingle(Console.ReadLine());

    return inteligencia2;
  }

  public static float Vitalidade(float vitalidade2)
  {
    Console.WriteLine("===Vitality===");
    Console.WriteLine("Discription TBW");

    Console.Write("Points: ");
    vitalidade2 = Convert.ToSingle(Console.ReadLine());

    return vitalidade2;
  }
} 