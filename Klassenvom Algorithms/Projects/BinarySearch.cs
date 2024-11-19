using System.ComponentModel.Design;

namespace Algorithms.Projects;

public class BinarySearch
{
    public static void DoBinarySearch(string[] args)
    {
        // BubbleSort.DoBubbleSort(null);


        



        Random randNum = new Random();

        int[] array = new int [10];


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next( 101);



        }

        Console.WriteLine("Das zufällig unsortierte Array: ");
        
        Console.WriteLine();
        
        PrintArray(array);

        Console.WriteLine();

        QuickSort(array, 0, array.Length - 1);
        Console.WriteLine("Das endgültig sortierte Array: ");
        
        Console.WriteLine();
        PrintArray(array);
        
        
        Console.WriteLine();
        
        Console.WriteLine("Enter a valid  Input: ");
        int UserInput = Convert.ToInt32(Console.ReadLine());
        int result = BinSearch(array, array.Length, UserInput);

        if (result > -1)
        {

            Console.WriteLine("The target value was found in the array at index: " + result);
        }
        else
        {

            Console.WriteLine("The target value was not found in the array.");
        }

    }

    static int partition(int[] array, int low, int high)
    {


        int pivot = array[low];
        int i = low + 1;
        int j = high;

        int temp;

// wiederhole den Prozess, solange sich i und j nicht überkreuzt haben
        while (i <= j)
        {

            while (i <= j && pivot >= array[i])
            {

                i++;
                
            }


            while (i <= j && pivot <= array[j])
            {

                j--;
            }

// verausche i und j nur, wenn die beiden unterschiedlichen Position haben
          
            
            if (i < j)
            {

                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                
                Console.WriteLine();
                Console.WriteLine("Der Zwischenschrit vom array: ");
                Console.WriteLine();
                PrintArray(array);


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


    static void QuickSort(int[] array, int low, int high)
    {
       
        if (low < high)
        {
            
            int pivot_index = partition(array, low, high); // gibt immer 
          

            
            QuickSort(array, low, pivot_index - 1);
            QuickSort(array, pivot_index + 1, high); 
        }
        
        



    }




    static int BinSearch(int[] array, int n, int key)
    {

        int low = 0;

        int high = n - 1;
        
        while (low <= high)
        {

            int mid = (low + high) / 2;
            
            Console.WriteLine("Checking middle index " + mid + " with value "  + array[mid]);

            if (key == array[mid])
            {

                return mid;



            }

            else if (key < array[mid])
            {
                high = mid - 1;
            }

            else
            {

                low = mid + 1;





            }



        }





        return -1;
        
    }



    static void PrintArray(int[] array)
    {


        foreach (var element in array)
        {
            Console.Write(element + " " );
            
            
        }
        
        Console.WriteLine();
        
        
    }
}



