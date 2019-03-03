using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__4____._._2n__recursive
{
    //kullanıcı tarafından girilen bir sayıyı(n) 2!+4!+...2n! seklinde toplayan programı
    //recursive yontemı ıle yapınız
    class Program
    {
        static int faktoriel(int a)
        {
            if (a == 0) return 1;
            else
            return a * (faktoriel(a - 1));
        }
        static int faktoplam(int a)
        {
            int toplam = 0;
            for (int i = 2; i < 2 * a; i += 2)
                toplam += faktoriel(i);
            return toplam;

        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int snc = faktoplam(a);
            Console.WriteLine(snc);
        }
    }
}
