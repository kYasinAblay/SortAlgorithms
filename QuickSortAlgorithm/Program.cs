using QuickSortAlgorithm;
using SayiListesiOlusturLibrary;

//Doğru çalışmıyor düzeltilme bekleniyor
var sayilar = new CreateNumberList(50).SayiKümesiOluştur();


void quickSort(ref int[] A, int p, int r)
{
  int q;
  if (p < r)
  {
    q = partition(A, p, r);
    quickSort(ref A, p, q - 1);
    quickSort(ref A, q + 1, r);
  }
}

int partition(int[] A, int p, int r)
{
  int tmp;
  int x = A[r];
  int i = p - 1;

  for (int j = p; j <= r - 1; j++)
  {
    if (A[j] <= x)
    {
      i++;
      tmp = A[i];
      A[i] = A[j];
      A[j] = tmp;
    }
  }
  tmp = A[i + 1];
  A[i + 1] = A[r];
  A[r] = tmp;

  return i + 1;
}

quickSort(ref sayilar, sayilar[sayilar.Length / 2], sayilar.Length / 2);


for (int i = 0; i < sayilar.Length; i++)
{
  Console.WriteLine(sayilar[i]);
}


Console.ReadKey();