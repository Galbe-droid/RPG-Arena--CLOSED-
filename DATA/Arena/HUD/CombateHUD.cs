using System;
using System.IO;
using System.Collections.Generic;

class CombateHUD
{
  public static void PlayerHUD(int IDP)
  {
    float danoP = 0;
    float manaGastaP = 0;

    HUD.InformacoesGerais(IDP);
    
    Console.WriteLine();

    HUD.VidaMana(IDP, danoP, manaGastaP);
    
    Console.WriteLine();
    Console.WriteLine();

    HUD.Equipamentos(IDP);

    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("===========================");
    Console.ResetColor();
  }

  public static bool PlayerStatus(int IDP, float danoP, float PontoDeVida, bool playerMorto)
  {
    if(danoP == PontoDeVida)
    {
      playerMorto = true;
    }

    return playerMorto;
  }

  public static void MonstroHUD(int IDM, float dano)
  {
    float manaGasta = 0; 

    foreach(Monstro m in Listas.monstroDia)
    {
      if(IDM == m.IDMonstro)
      {
        Console.WriteLine($"Name: {m.Nome} / Level: {m.Nivel} / Rank: {m.Rank}");
        Console.WriteLine();
        Console.WriteLine($"Str:{m.Forca} / Dex:{m.Destreza} / Int:{m.Inteligencia} / Vit:{m.Vitalidade}");

        float vidaAtual = m.PontosDeVida - dano;
        float manaAtual = m.PontosDeMana - manaGasta;

        float barraVida = m.PontosDeVida / 9;
        float barraMana = m.PontosDeMana / 9;

        float somaVida = 0;
        float somaMana = 0;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("HP:");
        Console.Write("{");
        
        while(vidaAtual >= somaVida && vidaAtual <= m.PontosDeVida)
        {
          Console.Write("=");
          somaVida = barraVida + somaVida;
        }
        while(vidaAtual <= somaVida && somaVida <= m.PontosDeVida)
        {
          Console.Write("-");
          somaVida = barraVida + somaVida;
        }
        Console.Write($"}} {vidaAtual}/{m.PontosDeVida}");
        Console.ResetColor();

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("MP:");
        Console.Write("{");
        while(manaAtual >= somaMana && manaAtual <= m.PontosDeMana)
        {
          Console.Write("=");
          somaMana = barraMana + somaMana;
        }
        while(manaAtual <= somaVida && somaMana <= m.PontosDeMana)
        {
          Console.Write("-");
          somaMana = barraMana + somaMana;
        }
      
        Console.Write($"}} {manaAtual}/{m.PontosDeMana}");
        Console.ResetColor();
        Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("===========================");
    Console.ResetColor();
      }
  }
  }

  public static bool MonstroStatus(int IDM, float danoM, float PontosDeVida, bool monstroMorto)
  {
    if(danoM == PontosDeVida)
    {
      monstroMorto = true;
    }

    return monstroMorto;
  }
}