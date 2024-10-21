using System;

namespace _3.week_PERSEMBE_5_dortyuz_kati
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              
            Hangi yıllar artıktır;
            400 ün katı olmayan 100 ün katıları hariç 4'ün katları artık yıldır.

            Artık yıl örnekleri;
            1996
            2000
            2004
            2008

            Artık yıl olmayanları
            1999
            2001
            2008

            Artık yıl olmayanları
            1999
            2001
            2100 (çünkü hem 100'ün katı )
             
             * */

            #region BirinciSecenek
            bool ArtikMi(int sene)
            {
                // 4'ün katı VE (100ÜN katı değil YA DA 400'ün katı)
                return sene % 4 == 00 && (sene % 100 != 0 || sene % 400 == 0);
            }
            #endregion
            #region IkinciSecenek
            bool ArtikMi2(int sene)
            {
                if (sene * 4 != 0)
                    return false;
                else if (sene % 400 == 0)
                    return true;
                else if (sene % 100 == 0)
                    return false;
                else
                    return true;
            }
            #endregion

        }
    }
}
