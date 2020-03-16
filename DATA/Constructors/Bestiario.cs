using System;
using System.IO;
using System.Collections.Generic;


class Bestiario
{

  public static void AdicionarMonstros()
  {
    //(nome, rank, categoria, nivel, For, Des, int, vit)
    Listas.AdicionarMonstros("Slime", 1, "Ground", 1, 4, 4, 2, 2);
    Listas.AdicionarMonstros("Golem", 1, "Ground", 1, 8, 2 , 2, 8);

    //Teste
    Listas.RepositorioJogador("Gabriel", 0, 24, 8, 4, 4, 8, false, false);
  }
}