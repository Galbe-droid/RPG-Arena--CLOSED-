using System;
using System.IO;
using System.Collections.Generic;

public class Player
{
  public int IDPlayer;
  //Informação do perosnagem
  public string NomePlayer;
  //public Job Profissão;
  public float Experiencia;

  //Atributos não modificaveis 
  public float PontoDeVida;
  public float PontoDeMana;

  //Atributos modificaveis
  public float PontosDeAtributos;
  public float Força;
  public float Destreza;
  public float Inteligencia;
  public float Vitalidade;

  //Equipamento
  public bool TemArma;
  public bool TemArmadura;
  
  public Player(int idPlayer, string nomePlayer, float Exp, float PdV, float PdM, float Atributos,float For, float Des, float Int, float Vit, bool temArma, bool temArmadura)
  {
    IDPlayer = idPlayer;

    NomePlayer = nomePlayer;
    Experiencia = Exp;

    PontoDeVida = PdV;
    PontoDeMana = PdM;

    PontosDeAtributos = Atributos;
    Força = For;
    Destreza = Des;
    Inteligencia = Int;
    Vitalidade = Vit;

    TemArma = temArma;
    TemArmadura = temArmadura;
  }
}