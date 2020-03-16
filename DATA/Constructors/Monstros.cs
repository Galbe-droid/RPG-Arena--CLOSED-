using System;
using System.IO;
using System.Collections.Generic;

public class Monstro
{
  public int IDMonstro{get; set;}
  public string Nome{get; set;}

  //Quanto maior o rank mais pontos o monstro recebera em seus status
  public int Rank{get; set;}

  //Terrestre, Voador, aquatico 
  public string Categoria{get; set;}

  public int Nivel{get; set;}

  //Atributo não manipulaveis
  
  public float PontosDeVida{get; set;}
  public float PontosDeMana{get; set;}

  //Atributos manipulaveis
  public float Forca{get; set;}
  public float Destreza{get; set;}
  public float Inteligencia{get; set;}
  public float Vitalidade{get; set;}

  public Monstro(int idMonstro, string nome, int rank, string cateogria, int nivel, float PdV, float PdM, float For, float Des, float Int, float Vit)
  {
    IDMonstro = idMonstro;
    
    Nome = nome;
    Rank = rank;
    Categoria = cateogria;
    Nivel = nivel;
    
    PontosDeVida = (Vitalidade + (3 + rank)) * 8 + 5;
    PontosDeMana = (Inteligencia + (3 + rank))  * 5 + 3;
   
    Forca = For;
    Destreza = Des;
    Inteligencia = Int;
    Vitalidade = Vit;
  }
}