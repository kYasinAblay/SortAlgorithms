using MergeAlgoritması;
using SayiListesiOlusturLibrary;
using System.Diagnostics;

var sayilar = new CreateNumberList(100000000).SayiKümesiOluştur();


var mainSort = new MergeMain();
var sp = new Stopwatch();
sp.Start();
var sortedList = mainSort.mergesort(sayilar);
sp.Stop();


//for (int i = 0; i < sortedList.Length; i++)
//{
//  Console.WriteLine(sortedList[i]);
//}
Console.WriteLine("______");
Console.WriteLine("Geçen Zaman:" + sp.Elapsed.TotalSeconds);



Console.ReadKey();