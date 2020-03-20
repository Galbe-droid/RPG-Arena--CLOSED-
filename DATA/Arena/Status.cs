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
}