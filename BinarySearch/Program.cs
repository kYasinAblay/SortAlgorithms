using BinarySearch;
using SayiListesiOlusturLibrary;
//int sayac = 0;
var sayilarim = new CreateNumberList(1000000).SayiKümesiOluştur();

var mergeSort = new MergeMain();
var sortedList = mergeSort.mergesort(sayilarim);

int target = 500;
int low = 0;
int high = sortedList.Length - 1;
int mid = (low + high) / 2;


var ArananSayi = sortedList.ToList().IndexOf(target);

if (ArananSayi == -1)
  Console.WriteLine("Aradığınız sayı bu dizide mevcut değil!");


while (ArananSayi != -1 && low <= high)
{
  mid = (low + high) / 2;
  if (target == sortedList[mid])
  {
    Console.WriteLine("{0} Sayı Bulundu. Sıra numarası: {1}.", sortedList[mid], mid);
    Console.WriteLine("Aranan sayı değeri: " + ArananSayi);
    break;
  }
  else if (target < sortedList[mid])
    high = mid - 1;
  else if (target > sortedList[mid])
    low = mid + 1;
  else break;
}


//Console.WriteLine("Sayac: " + sayac);

Console.ReadKey();