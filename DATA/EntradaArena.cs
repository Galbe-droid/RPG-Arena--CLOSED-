using System;
using System.IO;
using System.Collections.Generic;

class EntradaArena
{
  public static void VisaoPersonagem(string nomeP, float expP,float pdvP, float pdmP, float forP, float desP, float intP, float vitP, bool armaP, bool armaduraP)
  {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("       Arena Entrace");  
    Console.WriteLine("===========================");
    Console.ResetColor();

    Console.WriteLine($"Nome: {nomeP}     Exp: {expP}");
    Console.WriteLine();
    Console.WriteLine($"Str:{forP} / Dex:{desP} / Int:{intP} / Vit:{vitP}");
    Console.WriteLine();

    HUD(pdvP, pdmP);
    
    Console.WriteLine();

    Equipamentos(armaP, armaduraP);

    Console.ReadLine();

  }

  public static void HUD(float vidaMax , float manaMax)
  {
    float dano = 20;
    float manaGasta = 0;

    float vidaAtual = vidaMax - dano;
    float manaAtual = manaMax - manaGasta;

    float barraVida = vidaMax / 10;
    float barraMana = manaMax / 10;

    float somaVida = 0;
    float somaMana = 0;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("HP:");
    Console.Write("{");
    while(vidaAtual >= somaVida && vidaAtual <= vidaMax)
    {
      Console.Write("=");
      somaVida = barraVida + somaVida;
    }
    while(vidaAtual <= somaVida && somaVida <= vidaMax)
    {
      Console.Write("-");
      somaVida = barraVida + somaVida;
    }
  Console.Write($"}} {vidaAtual}/{vidaMax}");
    Console.ResetColor();

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("MP:");
    Console.Write("{");
    while(manaAtual >= somaMana && manaAtual <= manaMax)
    {
      Console.Write("=");
      somaMana = barraMana + somaMana;
    }
    while(manaAtual <= somaVida && somaMana <= manaMax)
    {
      Console.Write("-");
      somaMana = barraMana + somaMana;
    }
    Console.Write($"}} {manaAtual}/{manaMax}");
    Console.ResetColor();
  }

  public static void Equipamentos(bool armaE, bool armaduraE)
  {
    Console.Write("Weapon: ");
    if(armaE == false)
    {
      Console.WriteLine("No Weapon");
    }

    Console.Write("Armor: ");
    if(armaduraE == false)
    {
      Console.WriteLine("No Armor");
    }
  }
}