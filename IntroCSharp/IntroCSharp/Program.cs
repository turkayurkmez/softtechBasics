using System;


namespace IntroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            int age = 42;

            /*
             * sayısal
             *   - tam sayılar
             *   - ondalıklı 
             * sözel
             * mantıksal
             */
            //-tam sayılar
            byte byteMax = 255;
            sbyte minByte = -128;

            short shortMax = 32767;
            //byte hariç tüm tam sayılar negatif olabilirler. Negatif olmamasını isterseniz "unsigned" seçenekleri vardır.
            ushort positiveShort = 65535;
            int intMax = 42;
            long enBuyukTamSayi = 0;

            // ondalıklı

            double rate = 1.64;
            float discount = 0.15f;
            decimal maxVariable = 0.0000000000000000000000000000000000000001M;


            //sözel
            char karakter = 'a';
            string name = "Türkay Ürkmez";

            //mantıksal
            bool olduMu = false;

            var word = "computer";

            var x = 0.65;

            var isHot = true;




        }
    }
}
