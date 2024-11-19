namespace Algorithms.Projects;

public class BubbleSort
{

    public static void DoBubbleSort(string[] args)
    {
        
        
        Random randNum = new Random();
        

        int[] array = new int [10];
        
        
        // Initialisiert das Array mit 10 zufälligen Werten

        for (int i = 0; i < array.Length; i++)
        {


            array[i] = randNum.Next(1, 100);


        }

        Console.WriteLine("Das unsortierte Array");
        PrintArray(array);
        
        
        ImplementBubbleSort(array);



    }


    static void ImplementBubbleSort(int[] array)
    {


        int temp;
        bool swapped;
        int n = array.Length;
        int comp= 0 ;
        int vertausch = 0;



        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                comp += 1;

                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                    vertausch += 1;
                    
                    Console.WriteLine("Der Zwischenschritt vom Array");
                    PrintArray(array);

                }


                if (swapped == false)
                {
                    Console.WriteLine("Es wurden " + comp + " Vergleiche und " + vertausch + " Vertaauschungen stattgefunden");


                    Console.WriteLine("Das endgülig sortierte Array: ");
                    
                    PrintArray(array);
                    break;




                }





            }


        }





    }


    static void PrintArray(int[] array)
    {

        foreach (var element in array)
        {
            Console.Write(element + " ");

        }

        Console.WriteLine();


    }
}
    
    
    
    
    
    
