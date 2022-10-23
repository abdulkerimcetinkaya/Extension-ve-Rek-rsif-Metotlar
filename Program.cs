using System;

namespace Rekürsif_Extension_Metotlar
{
    class Program
    {
        static void Main(String[] args)
        {
            // Rekürsif - Öz Yinelemeli
            // 3^4 3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            islemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));

            // Extension metotlar

            string ifade = "Abdulkerim Çetinkaya";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            System.Console.WriteLine(ifade.GetFirstCharacter());

        }
    }

    public class islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
             Array.Sort(param);
             return param;
        }

        public static void EkranaYazdır(this int[] param)
        {
            foreach (int item in param)
            System.Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
