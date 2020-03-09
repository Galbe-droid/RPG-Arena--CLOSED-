using System;
using System.IO;


public class Confirmacao
{
  public static bool ExistePersonagem()
  {
    if(Directory.GetFiles($@"DATA/PersonagensSalvos").Length == 0)
    {
      return false;
    }
    else
    {
      return true;
    }
  }
}