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
      Console.WriteLine("You return to normal combate posture");
      Console.ReadLine();
      cooldown = 0;
      return defesaAtivaP;
    }
    else
    {
      return defesaAtivaP;
    }
  }

  public static bool DefenderMonstro (bool defesaAtivaM, int cooldown)
  {
    if(defesaAtivaM == true && cooldown < 4)
    {
      cooldown ++;
      return defesaAtivaM;
    }
    else if(defesaAtivaM == true && cooldown == 4)
    {
      defesaAtivaM = false;
      Console.WriteLine("Monster return to it normal posture");
      Console.ReadLine();
      cooldown = 0;
      return defesaAtivaM;
    }
    else
    {
      return defesaAtivaM;
    }
  }
}