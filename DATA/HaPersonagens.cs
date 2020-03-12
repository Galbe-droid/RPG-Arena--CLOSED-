using System;
using System.IO;
using System.Collections.Generic;


public class Confirmacao
{
  public static bool ExistePersonagem(int jogadorConfirmados)
  {
    

    if(Directory.GetFiles($@"DATA/PersonagensSalvos").Length == 0 && jogadorConfirmados == 0)
    {
      return false;
    }
    else
    {
      return true;
    }
  }
}