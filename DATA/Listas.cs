using System;
using System.IO;
using System.Collections.Generic;

 public class Listas
{
  public static List<Player> jogadores = new List<Player>();
  
  //public static List<Armas> armamentos;
  //public static List<Itens> consumiveis;
  
  //Adiciona o personagem a uma lista
  public static void RepositorioJogador(string nome, float experiencia, float PdVTotal, float PdMTotal, float atributo, float forca, float destreza, float inteligencia, float vitalidade, bool temArma, bool temArmadura)
  {
    int ID = jogadores.Count + 1;

    jogadores.Add(new Player(ID, nome, experiencia, PdVTotal, PdMTotal, atributo, forca, destreza, inteligencia, vitalidade, temArma, temArmadura));

    //Contador de quanto personagens forma criados.
    int contador = jogadores.Count;
  }
}