using System;
using System.IO;
using System.Collections.Generic;

class Temporario
{
  public static void Bestiario()
  {
    foreach(Monstro m in Listas.monstro)
    {
      Console.WriteLine($"{m.IDMonstro},{m.Nome},{m.Rank},{m.Categoria},{m.Nivel},{m.PontosDeVida},{m.PontosDeMana},{m.Forca},{m.Destreza},{m.Inteligencia},{m.Vitalidade}");
    }
	Console.WriteLine($"{Listas.monstro}");
  } 
}