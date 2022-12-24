
using SayiListesiOlusturLibrary;
using System.Diagnostics;
using System.Security.Cryptography;

int[] sayilar;
var sp = new Stopwatch();

//Kendi yazdığım algoritma
var sayilarim = new CreateNumberList(1000).SayiKümesiOluştur();
int sayac = 0;


sp.Start();
for (int i = 0; i < sayilarim.Length; i++)
{
  for (int j = i + 1; j < sayilarim.Length; j++)
  {
    if (sayilarim[i] > sayilarim[j])
    {
      int sayi = sayilarim[i];
      sayilarim[i] = sayilarim[j];
      sayilarim[j] = sayi;
      sayac++;
      Console.WriteLine(sayilarim[i]);
    }
  }
  sayac++;
}
sp.Stop();




Console.WriteLine("Sayac: " + sayac);
Console.WriteLine("Geçen Zaman:" + sp.Elapsed.TotalSeconds);


Console.ReadKey();
