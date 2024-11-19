using System;

namespace Algorithms.Projects
{
    public class QuickSort
    {
        public static void DoQuickSort(string[] args)
        {
            int[] array = new int[10];
            Random randNum = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(1, 100)+1;
            }

            Console.WriteLine("Das unsortierte Array:");
            PrintArray(array);

            ImplementQuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Das endgültig sortierte Quicksort-Array:");
            PrintArray(array);
        }

        // Führt das Partitionierungsverfahren durch und gibt den Index des Pivots zurück
        private static int Partitioning(int[] array, int low, int high)
        {
            int pivot = array[low];
            int i = low + 1;
            int j = high;
            int temp;

            while (i <= j)
            {
                while (i <= j && pivot > array[i])

                {
                    
                    i++;
                }
                
                
                while (i <= j && pivot < array[j])
                    
                {  j--;}

                if (i < j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                else
                {
                    break;
                }
            }

            array[low] = array[j];
            array[j] = pivot;

            return j;
        }

        // Implementiert den QuickSort-Algorithmus
        private static void ImplementQuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partitioning(array, low, high);

                Console.WriteLine("Das Zwischenschritt vom Array:");
                PrintArray(array);

                // Linke Seite sortieren
                ImplementQuickSort(array, low, pivotIndex - 1);
                // Rechte Seite sortieren
                ImplementQuickSort(array, pivotIndex + 1, high);
            }
        }

        // Gibt das Array aus
        private static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
