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

  public static bool PlayerStatus(int IDP, float danoP, float PontoDeVida)
  {
    bool playerMorto = false;

    if(danoP == PontoDeVida)
    {
      playerMorto = true;
    }

    return playerMorto;
  }

  public static void MonstroHUD(int IDM)
  {
    float danoM = 0;
    float manaGastaM = 0; 

    HUD.MonstroInfoBasico(IDM);
    
    Console.WriteLine();

    HUD.MonstroVidaMana(IDM, danoM, manaGastaM);
    
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("===========================");
    Console.ResetColor();
  }

  public static bool MonstroStatus(int IDM, float danoM, float PontosDeVida)
  {
    bool monstroMorto = false;

    if(danoM == PontosDeVida)
    {
      monstroMorto = true;
    }

    return monstroMorto;
  }
}