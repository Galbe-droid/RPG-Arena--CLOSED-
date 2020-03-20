using System;
using System.IO;
using System.Collections.Generic;

public class Combate
{
  public static void CombateTurno(int IDP, int IDM)
  {
    Random rnd = new Random();
    float danoP = 0;
    float danoM = 0;

    float manaGastaP = 0;
    float manaGastaM = 0;

    float forP = 0;
    float desP = 0;
    float intP = 0;
    float vitP = 0; 
    float PontoDeVida = 0;

    float forM = 0;
    float desM = 0;
    float intM = 0;
    float vitM = 0; 
    float PontosDeVida = 0;

    foreach(Player p in Listas.jogadores)
    {
      if(IDP == p.IDPlayer)
      {
        forP = p.Forca;
        desP = p.Destreza;
        intP = p.Inteligencia;
        vitP = p.Vitalidade;
        PontoDeVida = p.PontoDeVida;
      }
    }
    foreach(Monstro m in Listas.monstroDia)
    {
      if(IDM == m.IDMonstro)
      {
        forM = m.Forca;
        desM = m.Destreza;
        intM = m.Inteligencia;
        vitM = m.Vitalidade;
        PontosDeVida = m.PontosDeVida;
      }
    }

    bool escape = false;
    

    bool PMorto = CombateHUD.PlayerStatus(IDP, danoM, PontoDeVida);
    bool MMorto = CombateHUD.MonstroStatus(IDM, danoM, PontosDeVida);

    while(true)
    {
      int turno = 1;
      bool turnoP = false;
      bool turnoM = false;
      float iniciativaP;
      float iniciativaM;
      
      

      while(true)
      {
        float escaparP = desP + rnd.Next(1,20);
        float impedirM = desM + rnd.Next(1,20);
      
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"     Combat Turn:{turno}   ");  
        Console.WriteLine($"===========================");
        Console.ResetColor();

        CombateHUD.PlayerHUD(IDP);
        CombateHUD.PlayerStatus(IDP, danoM, PontoDeVida);

        CombateHUD.MonstroHUD(IDM);
        CombateHUD.MonstroStatus(IDM, danoM, PontosDeVida);

        do
        {
          iniciativaP = intP + rnd.Next(1,20);
          iniciativaM = intM + rnd.Next(1,20);
        }while(iniciativaM == iniciativaP);

        while(true)
        {
          if(iniciativaP > iniciativaM || turnoP == false)
          {
            Console.WriteLine("Player Move");
            DecisaoP(escaparP, impedirM, escape);
            turnoP = true;
          }
          else if(iniciativaP < iniciativaM || turnoM == false)
          {
            Console.WriteLine("Monster Move");
            turnoP = true;
          }
          Console.ReadLine();
          if(escape == true)
          {
            break;
          }
        }
        if(escape == true)
        {
          break;
        }
      }
      if(escape == true)
      {
        break;
      }
    }
    if(escape == true)
    {
      break;
    }
  }

  public static void DecisaoP(float escapar, float impedir, bool escapeP)
  {
    string decisao;

    Console.WriteLine("A - Attack\nD - Defense\nR - Run");

    decisao = Console.ReadLine().ToUpper();

    switch(decisao)
    {
      case"A":
        break;

      case"D":
        break;

      case"R":
        if(escapar > impedir)
        {
          Console.WriteLine("You Escaped");
          escapeP = true;
        }
        break;

      default:
        break;
    }
  }
}
