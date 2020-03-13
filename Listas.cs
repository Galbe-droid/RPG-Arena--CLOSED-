using System;
using System.IO;
using System.Collections.Generic;

 public class Listas
{
  public static List<Player> jogadores;
  //public static List<Armas> armamentos;
  //public static List<Itens> consumiveis;

  public static void RepositorioJogador(string nome2, float experiencia2, float PdVTotal2, float PdMTotal2, float atributo2, float forca2, float destreza2, float inteligencia2, float vitalidade2, bool temArma2, bool temArmadura2)
  {
    jogadores = new List<Player>();

    int ID = jogadores.Count + 1;

    jogadores.Add(new Player(ID, nome2, experiencia2, PdVTotal2, PdMTotal2, atributo2, forca2, destreza2, inteligencia2, vitalidade2, temArma2, temArmadura2));

    int contador = jogadores.Count;
  }
}