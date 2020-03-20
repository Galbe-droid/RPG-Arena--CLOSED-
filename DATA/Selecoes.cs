using System;
using System.IO;
using System.Collections.Generic;

class Selecao
{
  public static void SelecionarPersonagem()
  {
    Console.Clear();
    int ID = 0;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("   Character Selection");  
    Console.WriteLine("===========================");
    Console.ResetColor();

    string opcaoPersonagem;
    string escolherDenovo;
    foreach(Player p in Listas.jogadores)
    {
      Console.WriteLine($"Name: {p.NomePlayer}");
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("===========================");
    Console.ResetColor();

    while(true)
    {
      Console.WriteLine("Select a character by NAME.");
      Console.Write("Name: ");
      do
      {
        opcaoPersonagem = Console.ReadLine().ToUpper();
      }while(opcaoPersonagem == String.Empty);

      foreach(Player p in Listas.jogadores)
      {
        if(opcaoPersonagem == p.NomePlayer.ToUpper())
        {
          //transporta os valores da lista para uma variavel que sera usada dentro do jogo

          ID = p.IDPlayer;
        }
      }

      Console.WriteLine("You are going to take control of...");

      foreach(Player p in Listas.jogadores)
      {
        if(ID == p.IDPlayer)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"============={p.NomePlayer}==============");
          Console.ResetColor();

          Console.WriteLine($"Character Experience: {p.Experiencia}");
      
          Console.WriteLine();

          Console.WriteLine($"Max HP: {p.PontoDeVida}    Max MP: {p.PontoDeMana}");

          Console.WriteLine();

          Console.WriteLine($"Str:{p.Forca} / Dex:{p.Destreza} / Int: {p.Inteligencia} / Vit: {p.Vitalidade}");
        }
      }

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("===========================");
      Console.ResetColor();

      Console.WriteLine("This is your choice ? [Y/N]");
      Console.Write(">>> Option: ");
      escolherDenovo = Console.ReadLine().ToUpper();

      if(escolherDenovo == "Y")
      {
        EntradaArena.VisaoPersonagem(ID);
        
        break;
      }
    }
  }

  public static void SelecionarMonstro()
  {
    //Gera uma seleção aleatoria dos monstros que aparecerão na arena.
    int contador = Listas.monstro.Count;
    Random rnd = new Random();
    for(int i = 0; i < 3; i++)
    {
      int IDSorteio = rnd.Next(1,contador+1);

      foreach(Monstro m in Listas.monstro)
      {
        if(IDSorteio == m.IDMonstro)
        {
          int randLVL = m.Nivel + rnd.Next(0, 2);
          int randRank = m.Rank + rnd.Next(0, 1);

          int extraPoints = (randRank * 2) + (randLVL * 2);

          float extraFor = 0;
          float extraDes = 0;
          float extraInt = 0;
          float extraVit = 0;

          float extraSoma = extraDes + extraFor + extraInt + extraVit;

          while(extraSoma != extraPoints )
          {
            extraFor = 0 + rnd.Next(0, extraPoints);
            
            extraDes = 0 + rnd.Next(0, extraPoints);
            
            extraInt = 0 + rnd.Next(0, extraPoints);
            
            extraVit = 0 + rnd.Next(0, extraPoints);
            
            extraSoma = extraDes + extraFor + extraInt + extraVit;
          }

          float novaFor = m.Forca + extraFor;
          float novaDes = m.Destreza + extraDes;
          float novaInt = m.Inteligencia + extraInt;
          float novaVit = m.Vitalidade + extraVit;
          
          Listas.AdicionarMonstrosDia(m.Nome, randLVL, m.Categoria, randRank, novaFor, novaDes, novaInt, novaVit);
        }
      }
    }
  }
}