using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;

namespace OP_k_WF
{
    public class GnomeSortProg
    {
        public void Swap(int[] mas, int i, int j)
        {
            int temp = mas[i];
            mas[i] = mas[j];
            mas[j] = temp;
        }

        public void GnomeSort(int[] inMas)
        {
            int i = 1;
            int j = 2;
            while (i < inMas.Length)
            {
                if (inMas[i - 1] < inMas[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(inMas, i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }
        }
    }
}
