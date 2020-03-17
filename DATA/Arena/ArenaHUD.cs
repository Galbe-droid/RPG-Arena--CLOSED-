using System;
using System.IO;
using System.Collections.Generic;

class HUD
{
  //Informação sobre os status do jogador
  public static void InformacoesGerais(string nomeHUD, float expHUD, float forHUD, float desHUD, float intHUD, float vitHUD)
  {
    Console.WriteLine($"Nome: {nomeHUD}     Exp: {expHUD}");
    Console.WriteLine();
    Console.WriteLine($"Str:{forHUD} / Dex:{desHUD} / Int:{intHUD} / Vit:{vitHUD}");
  }

  //Informação visual sobre a vida e a energia do jogador
  public static void VidaMana(float vidaMax , float manaMax, float dano, float manaGasta)
  {
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

  //Verificar se ha equipamentos no jogador
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