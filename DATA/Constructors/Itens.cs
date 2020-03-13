using System;
using System.IO;
using System.Collections.Generic;

public class Armas
{
  //Informação da arma
  private int IDArmas {get; set;}
  public string NomeArma {get; set;}
  public string Descrição {get; set;}

  //Status da arma 
  public float Dano {get; set;}
  public float Nivel {get; set;} 
  //public Job Permitido;

  public bool NaLoja {get; set;}

  public Armas (int idArmas, string nomeArma, float dano, float nivel, bool naLoja)
  {
    IDArmas = idArmas;
    NomeArma = nomeArma;
    Dano = dano;
    Nivel = nivel;
    NaLoja = naLoja;
  }
}

public class Itens
{
  //Informação do item
  private int IDItens {get; set;}
  public string NomeItem {get; set;}
  public string Descrição {get; set;}

  //Valores do item;
  //buff
  public float ValorPositivo {get; set;}
  //debuff
  public float ValorNegativo {get; set;} 

  //Pode ser usado em combate
  public bool EmCombate {get; set;} 
  //Sera encontrado na loja
  public bool NaLoja {get; set;}
}