using System;
using System.IO;
using System.Collections.Generic;

class Status
{
  public static bool Escapar(float escapar, float impedir, bool escaped)
  {
    if(escapar > impedir)
    {
      Console.WriteLine("You Escaped");
      escaped = true;
    }
    else
    {
      escaped = false;
    }
    return escaped;
  }

  public static bool DefenderPlayer (bool defesaAtivaP, int cooldown)
  {
    if(defesaAtivaP == true && cooldown < 4)
    {
      cooldown ++;
      return defesaAtivaP;
    }
    else if(defesaAtivaP == true && cooldown == 4)
    {
      defesaAtivaP = false;
      Console.WriteLine("Defesa Desativada");
      Console.ReadLine();
      cooldown = 0;
      return defesaAtivaP;
    }
    else
    {
      return defesaAtivaP;
    }
  }

  public static bool DefenserMonstro (bool defesaAtivaM, int cooldown)
  {
    
  }
}