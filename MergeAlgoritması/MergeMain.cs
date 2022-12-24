using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeAlgoritması
{
  public class MergeMain
  {

    public int[] mergesort(int[] m)
    {

      int x = 0;
      int y = 0;
      int mode = m.Length % 2;
      int middle = m.Length / 2 ;
      int[] left = new int[middle + mode];
      int[] right = new int[middle];
      int[] result = new int[(m.Length)];

      if (m.Length <= 1)
      {
        return m;
      }

      for (int i = 0; i < middle + mode; i++)
      {
        left[x] = m[i];
        x++;
      }
      for (int i = middle + mode; i < m.Length; i++)
      {
        right[y] = m[i];
        y++;
      }

      left = mergesort(left);
      right = mergesort(right);
      result = merge(left, right);
      return result;
    }
    public int[] merge(int[] left, int[] right)
    {
      int[] result = new int[left.Length + right.Length];

      int x = 0;
      int y = 0;
      int k = 0;

      while (left.Length > x && right.Length > y)
      {
        if (left[x] <= right[y])
        {
          result[k] = left[x];
          x++;
          k++;
        }
        else
        {
          result[k] = right[y];
          y++;
          k++;
        }
      }

      if (left.Length > x)
      {
        while (x < left.Length)
        {
          result[k] = left[x];
          x++;
          k++;
        }
      }

      if (right.Length > y)
      {
        while (y < right.Length)
        {
          result[k] = right[y];
          y++;
          k++;
        }
      }
      return result;
    }
  }
}
