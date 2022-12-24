using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiListesiOlusturLibrary
{
  public class CreateNumberList
  {
    int[] sayilar;

    public CreateNumberList(int length)
    {
      sayilar = new int[length];
    }

    public int[] SayiKümesiOluştur()
    {
      var rand = new Random();

      for (int i = 0; i < sayilar.Length; i++)
      {
        sayilar[i] = rand.Next(0, sayilar.Length - 1);
      }
      return sayilar;
    }

  }
}
