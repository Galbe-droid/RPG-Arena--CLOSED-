using System;
using System.IO;
using System.Collections.Generic;

public class Player
{
  public int IDPlayer {get; set;}
  //Informação do perosnagem
  public string NomePlayer {get; set;}
  //public Job Profissão;
  public float Experiencia {get; set;}

  //Atributos não modificaveis 
  public float PontoDeVida {get; set;}
  public float PontoDeMana {get; set;}

  //Atributos modificaveis
  public float PontosDeAtributos {get; set;}
  public float Forca {get; set;}
  public float Destreza {get; set;}
  public float Inteligencia {get; set;}
  public float Vitalidade {get; set;}

  //Equipamento
  public bool TemArma {get; set;}
  public bool TemArmadura {get; set;}
  
  public Player(int idPlayer, string nomePlayer, float Exp, float PdV, float PdM, float Atributos,float For, float Des, float Int, float Vit, bool temArma, bool temArmadura)
  {
    IDPlayer = idPlayer;

    NomePlayer = nomePlayer;
    Experiencia = Exp;

    PontoDeVida = PdV;
    PontoDeMana = PdM;

    PontosDeAtributos = Atributos;
    Forca = For;
    Destreza = Des;
    Inteligencia = Int;
    Vitalidade = Vit;

    TemArma = temArma;
    TemArmadura = temArmadura;
  }
}