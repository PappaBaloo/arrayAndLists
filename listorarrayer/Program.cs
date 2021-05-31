using System;
using System.Collections.Generic;

namespace listorarrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //en random för att ge värden till objekten
            Random assingedvalue = new Random();

            //lista av objekt
            List<string> Object = new List<string>() { "HP", "Population", "States", "Disco Moves" };

            //lista av värden
            List<int> value = new List<int>();

            //for-loop för att "ge" värden till objekten
            for (int i = 0; i < Object.Count; i++)
            {
                value.Add(assingedvalue.Next(1, 1000));

                Console.WriteLine("" + Object[i] + ", Assinged Value:" + value[i] + "");
            }

            int[] arrayValues = ArrayValuesMethod(assingedvalue);

            ArrayToListMethod(arrayValues);

            Console.ReadLine();
        }

        private static int[] ArrayValuesMethod(Random assingedvalue)
        {
            //Gör en int array med 6 slots där värdena är mellan 1 och 99
            int[] arrayValues = new int[6] { assingedvalue.Next(1, 100), assingedvalue.Next(1, 100), assingedvalue.Next(1, 100), assingedvalue.Next(1, 100), assingedvalue.Next(1, 100), assingedvalue.Next(1, 100) };

            //printar ut värdena
            for (int i = 0; i < arrayValues.Length; i++)
            {
                Console.WriteLine("Arrayvärderna: " + arrayValues[i] + "");
            }

            return arrayValues;
        }

        private static void ArrayToListMethod(int[] arrayValues)
        {
            //Gör arrayen till en list
            List<int> arrayToList = new List<int>(arrayValues);

            //Tar bort värdena i listan som är under 50
            Console.WriteLine("Alla värden:");
            arrayToList.ForEach(i => Console.WriteLine(i));
            arrayToList.RemoveAll(i => i > 50);
            Console.WriteLine("Alla värden under 50");
            arrayToList.ForEach(i => Console.WriteLine(i));

        }
    }
}
