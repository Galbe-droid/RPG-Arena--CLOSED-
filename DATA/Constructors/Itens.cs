using System;
using System.IO;
using System.Collections.Generic;

public class Armas
{
  //Informação da arma
  private int IDArmas;
  public string NomeArma;
  public string Descrição;

  //Status da arma 
  public float Dano;
  public float Nivel; 
  //public Job Permitido;

  public bool NaLoja;

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
  private int IDItens;
  public string NomeItem;
  public string Descrição;

  //Valores do item;
  //buff
  public float ValorPositivo;
  //debuff
  public float ValorNegativo; 

  //Pode ser usado em combate
  public bool EmCombate; 
  //Sera encontrado na loja
  public bool NaLoja; 
}