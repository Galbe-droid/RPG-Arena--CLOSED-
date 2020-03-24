using System;
using System.IO;
using System.Collections.Generic;

public class Combate
{
  public static void CombateTurno(int IDP, int IDM)
  {
    Random rnd = new Random();
    bool turnoP = false;
    bool turnoM = false;

    float danoP = 0;
    float danoM = 0;
    int cooldownDefesaP = 0;
    int cooldownDefesaM = 0;

    bool defesaExtraP = false;
    bool defesaExtraM = false;

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

    turnoP = false;
    turnoM = false;
    
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
      CombateHUD.PlayerHUD(IDP, danoP);
      CombateHUD.PlayerStatus(IDP, danoM, PontoDeVida, playerMorto);

      CombateHUD.MonstroHUD(IDM, danoM);
      CombateHUD.MonstroStatus(IDM, danoM, PontosDeVida, monstroMorto);


      while(iniciativaP > iniciativaM || turnoP == false && playerMorto == false)
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
                danoM = danoM + AtaquePlayer(nomeP, nomeM,desP, desM, forP, vitM, danoM, defesaExtraM);
              break;
            case"D":
              defesaExtraP = true;
              Console.WriteLine($"{nomeP} enter in a defesive posture");
              Console.ReadLine();
              break;
          }
        }
        turnoP = true;
        break;
      }
      while(iniciativaP < iniciativaM || turnoM == false && monstroMorto == false && escape == false)
      {
        Console.WriteLine("Monster Move");

        int decisao = rnd.Next(1,3);

        if(defesaExtraM == true){decisao = 1;}

        switch(decisao)
        {
          case 1:
            danoP = danoP + AtaqueMonstro(nomeM, nomeP, desM, desP, forM, vitP, danoP, defesaExtraP);
            break;

          case 2:
            defesaExtraM = true;
            Console.WriteLine($"{nomeM} enter in a defensive posture");
            Console.ReadLine();
            break;
        }
        turnoM = true;
        break;
      }
      
      //Verificar se esta morto
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

      //Defesa extra Player
      defesaExtraP = Status.DefenderPlayer(defesaExtraP, cooldownDefesaP);
      if(defesaExtraP == true){cooldownDefesaP++;}
      else if(defesaExtraP == false){cooldownDefesaP = 0;}

      //Defesa extra Monstro
      defesaExtraM = Status.DefenderMonstro(defesaExtraM, cooldownDefesaM);
      if(defesaExtraM == true){cooldownDefesaM++;}
      else if(defesaExtraM == false){cooldownDefesaM = 0;}

      //Fim do Turno
      if(turnoM == true && turnoP == true){turno++; break;}
      }
    
      //Fim do Combate
      if(escape == true || monstroMorto == true || playerMorto == true)
      {
        break;
      }
    }
  }  


  public static float AtaquePlayer(string nomeP, string nomeM,float desP, float desM, float forP, float vitM, float danoM, bool monstroDefesaExtra)
  {
    Random rnd = new Random();
    float precisaoP = desP + rnd.Next(1,20);
    float esquivaM = desM + rnd.Next(1,20);

    float defesaMonstro = vitM + rnd.Next(1,6);

    //Caso monstro tenha usado postura defensiva
    if(monstroDefesaExtra == true){defesaMonstro = defesaMonstro + vitM;}

    float golpePlayer = forP + rnd.Next(1,12);

    float danoTotal = golpePlayer - defesaMonstro;

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

  public static float AtaqueMonstro(string nomeM, string nomeP,float desM, float desP, float forM, float vitP, float danoP, bool playerDefesaExtra)
  {
    Random rnd = new Random();
    float precisaoM = desM + rnd.Next(1,20);
    float esquivaP = desP + rnd.Next(1, 20);

    float defesaPlayer = vitP + rnd.Next(1,6);

    //Caso Player esteja com postura defensiva
    if(playerDefesaExtra == true){defesaPlayer = defesaPlayer + vitP;}

    float golpeMonstro = forM + rnd.Next(1,12);

    float danoTotal = golpeMonstro - defesaPlayer;

    if(danoTotal < 0)
    {
      danoTotal = 0;
    }

    Console.WriteLine($"{nomeM} try to hit'{precisaoM}' {nomeP}.");
    Console.ReadLine();
    Console.WriteLine($"{nomeP} try to dodge {nomeM}'s attack and...");
    Console.ReadLine();

    if(precisaoM >= esquivaP && danoTotal != 0)
    {
      Console.WriteLine($"it hits !!!, unfortunaly causing {danoTotal} of damage.");
      Console.ReadLine();
      return danoTotal;
    }
    else if(precisaoM >= esquivaP && danoTotal == 0)
    {
      Console.WriteLine($"it hits !, but {nomeP} manage to block the attack. ");
      Console.ReadLine();
      return 0;
    }
    else if(precisaoM < esquivaP && esquivaP - precisaoM > 10)
    {
      Console.WriteLine($"{nomeM} didn't even hit near {nomeP}");
      Console.ReadLine();
      return 0;
    }
    else
    {
      Console.WriteLine($"{nomeM} fails to land the attack.");
      Console.ReadLine();
      return 0;
    }
  }
}
