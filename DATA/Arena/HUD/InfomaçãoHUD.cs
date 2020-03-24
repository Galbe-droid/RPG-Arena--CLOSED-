using System;
using System.IO;
using System.Collections.Generic;

class HUD
{
  //Informação sobre os status do jogador
  /*public static void InformacoesGerais(int IDP)
  {
    
      }
    }
  }

  //Informação visual sobre a vida e a energia do jogador
  public static void VidaMana(int IDP, float dano, float manaGasta)
  {
    foreach(Player p in Listas.jogadores)
    {
      if(IDP == p.IDPlayer)
      {
        
      }
    }
  }

  //Verificar se ha equipamentos no jogador
  public static void Equipamentos(int IDP)
  {
    foreach(Player p in Listas.jogadores)
    {
      if(IDP == p.IDPlayer)
      {
        
  }*/

  public static void GerarMonstro(int ID)
  {
    float dano = 0;
    float manaGasta = 0;
    
    CombateHUD.MonstroHUD(ID, dano);
    MonstroInfoBasico(ID);
    MonstroVidaMana(ID, dano, manaGasta);
  }

  public static void MonstroInfoBasico(int IDM)
  {
    foreach(Monstro m in Listas.monstroDia)
    {
      if(IDM == m.IDMonstro)
      {
        Console.WriteLine($"Name: {m.Nome} / Level: {m.Nivel} / Rank: {m.Rank}");
        Console.WriteLine();
        Console.WriteLine($"Str:{m.Forca} / Dex:{m.Destreza} / Int:{m.Inteligencia} / Vit:{m.Vitalidade}");
      }
    }
  }

  public static void MonstroVidaMana(int IDM, float dano, float manaGasta)
  {
    foreach(Monstro m in Listas.monstroDia)
    {
      if(IDM == m.IDMonstro)
      {
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
      }
    }
  }
  
}