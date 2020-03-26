using System;
using System.IO;
using System.Collections.Generic;

public class Monstro
{
  public int IDMonstro{get; set;}
  public string Nome{get; set;}

  //Quanto maior o rank mais pontos o monstro recebera em seus status
  public int Rank{get; set;}

  //Agressivo, Defensivo, Neutro
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
    Categoria = cateogria.ToUpper();
    Nivel = nivel;
    
    PontosDeVida = PdV;
    PontosDeMana = PdM;
   
    Forca = For;
    Destreza = Des;
    Inteligencia = Int;
    Vitalidade = Vit;
  }
}