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

    string nomeP = "";
    float forP = 0;
    float desP = 0;
    float intP = 0;
    float vitP = 0; 
    float PontoDeVida = 0;
    bool playerMorto = false;

    string nomeM = "";
    float forM = 0;
    float desM = 0;
    float intM = 0;
    float vitM = 0; 
    float PontosDeVida = 0;
    bool monstroMorto = false;

    foreach(Player p in Listas.jogadores)
    {
      if(IDP == p.IDPlayer)
      {
        nomeP = p.NomePlayer;
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
        nomeM = m.Nome;
        forM = m.Forca;
        desM = m.Destreza;
        intM = m.Inteligencia;
        vitM = m.Vitalidade;
        PontosDeVida = m.PontosDeVida;
      }
    }

    bool escape = false;
    int turno = 1;

    while(escape == false)
    {
    float iniciativaP;
    float iniciativaM;

    bool turnoP = false;
    bool turnoM = false;
    float escaparP = desP + rnd.Next(1,20);
    float impedirM = desM + rnd.Next(1,20);
      
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"     Combat Turn:{turno}   ");  
    Console.WriteLine($"===========================");
    Console.ResetColor();

    do
    {
      iniciativaP = intP + rnd.Next(1,20);
      iniciativaM = intM + rnd.Next(1,20);
    }while(iniciativaM == iniciativaP);

    while(turnoP != true && turnoM != true )
    {
      CombateHUD.PlayerHUD(IDP);
      CombateHUD.PlayerStatus(IDP, danoM, PontoDeVida, playerMorto);

      CombateHUD.MonstroHUD(IDM, danoM);
      CombateHUD.MonstroStatus(IDM, danoM, PontosDeVida, monstroMorto);


      if(iniciativaP > iniciativaM && turnoP == false && playerMorto == false)
      {
        Console.WriteLine("Player Move");
        string decisao;
        Console.WriteLine("A - Attack\nD - Defense\nR - Run");
        Console.Write(">>> Option: ");

        do
        {
          decisao = Console.ReadLine().ToUpper();
        }while(decisao == String.Empty);

        if(decisao == "R")
        {
          escape = Status.Escapar(escaparP, impedirM, escape);
        }
        else
        {
          switch(decisao)
          {
            case"A":
                danoM = danoM + AtaquePlayer(nomeP, nomeM,desP, desM, forP, vitM, danoM);
              break;

            case"D":
              break;

            default:
              Console.WriteLine("Invalid Option.");
              break;
          }
        }
        turnoP = true;
      }
      else if(iniciativaP < iniciativaM && turnoM == false && monstroMorto == false)
      {
        Console.WriteLine("Monster Move");
        turnoP = true;
      }

      if(danoP >= PontoDeVida)
      {
        danoP = PontoDeVida;
        playerMorto = true;
      }

      if(danoM >= PontosDeVida)
      {
        danoM = PontosDeVida;
        monstroMorto = true;
        Console.WriteLine("O monstro foi derrotado.");
        Console.ReadLine();
      }

      if(monstroMorto == true)
      {
        break;
      }

      //Fim do Turno
      break;
    }
    //Fim do Combate
    
    if(escape == true || monstroMorto == true || playerMorto == true)
    {
      break;
    }
    turno++;
    }
  }  


  public static float AtaquePlayer(string nomeP, string nomeM,float desP, float desM, float forP, float vitM, float danoM)
  {
    Random rnd = new Random();
    float precisaoP = desP + rnd.Next(1,20);
    float esquivaM = desM + rnd.Next(1,20);

    float defesaMonstro = vitM + rnd.Next(1,6);
    float golpePlayer = forP + rnd.Next(1,12);

    float danoTotal = golpePlayer - defesaMonstro;

    Console.WriteLine(danoTotal);
    if(danoTotal < 0)
    {
      danoTotal = 0;
    }

    Console.WriteLine($"{nomeP} try to hit'{precisaoP}' the target {nomeM}.");
    Console.ReadLine();
    Console.WriteLine($"{nomeM} try to dodge {nomeP}'s attack and...");
    Console.ReadLine();

    if(precisaoP >= esquivaM && danoTotal != 0) 
    {
      Console.WriteLine($"it hits !!!, causing {danoTotal} on damage.");
      Console.ReadLine();
      return danoTotal;
    }
    else if(precisaoP >= esquivaM && danoTotal == 0)
    {
      Console.WriteLine($"it hits !, but {nomeM} manage to absorbe all the attack");
      Console.ReadLine();
      return 0;
    }
    else if(precisaoP < esquivaM && esquivaM - precisaoP > 10)
    {
      Console.WriteLine("Not even close.");
      Console.ReadLine();
      return 0;
    }
    else
    {
      Console.WriteLine($"it fails to land the attack");
      Console.ReadLine();
      return 0;
    }
  }
}
