using System;
using System.IO;
using System.Collections.Generic;

class HUD
{
  //Informação sobre os status do jogador
  public static void InformacoesGerais(int IDP)
  {
    foreach(Player p in Listas.jogadores)
    {
      if (IDP == p.IDPlayer)
      {
        Console.WriteLine($"Nome: {p.NomePlayer}     Exp: {p.Experiencia}");
        Console.WriteLine();
        Console.WriteLine($"Str:{p.Forca} / Dex:{p.Destreza} / Int:{p.Inteligencia} / Vit:{p.Vitalidade}");
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
        float vidaAtual = p.PontoDeVida - dano;
        float manaAtual = p.PontoDeMana - manaGasta;

        float barraVida = p.PontoDeVida / 9;
        float barraMana = p.PontoDeMana / 9;

        float somaVida = 0;
        float somaMana = 0;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("HP:");
        Console.Write("{");
        while(vidaAtual >= somaVida && vidaAtual <= p.PontoDeVida)
        {
          Console.Write("=");
          somaVida = barraVida + somaVida;
        }
        while(vidaAtual <= somaVida && somaVida <= p.PontoDeVida)
        {
          Console.Write("-");
          somaVida = barraVida + somaVida;
        }
        Console.Write($"}} {vidaAtual}/{p.PontoDeVida}");
        Console.ResetColor();

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("MP:");
        Console.Write("{");
        while(manaAtual > somaMana && manaAtual <= p.PontoDeMana)
        {
        Console.Write("=");
        somaMana = barraMana + somaMana;
        }
        while(manaAtual < somaVida && somaMana <= p.PontoDeMana)
        {
        Console.Write("-");
        somaMana = barraMana + somaMana;
        }
        Console.Write($"}} {manaAtual}/{p.PontoDeMana}");
        Console.ResetColor();
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
        Console.Write("Weapon: ");
        if(p.TemArma == false)
        {
         Console.WriteLine("No Weapon");
        }

        Console.Write("Armor: ");
        if(p.TemArmadura == false)
        {
          Console.WriteLine("No Armor");
        }
      }
    } 
  }

  public static void GerarMonstro(int ID)
  {
    float dano = 0;
    float manaGasta = 0;
    
    CombateHUD.MonstroHUD(ID);
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