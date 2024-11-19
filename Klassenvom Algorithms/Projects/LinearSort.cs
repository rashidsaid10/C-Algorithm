namespace Algorithms.Projects;

public class LinearSort
{
    public static void DoLinearSort(String[] args)
    {


        Console.WriteLine("Hello world from LinearSort algorithm!");
        
        Random randNum = new Random();

        int[] array = new int [10];
        
        for(int i = 0; i < array.Length; i++)
        {

            array[i] = randNum.Next(1, 100) + 1;
        }

        Console.WriteLine("Enter a valid number: ");

        int key = Convert.ToInt32(Console.ReadLine());


        int result = Search(array, key);

        if (result == -1)
        {
            Console.WriteLine("The number you entered was not found  in the array! ");
            
            
        }


        else
        {

            Console.WriteLine("The number you entered was found in the array at index: " + result);


        }


        Console.WriteLine();
        
        PrintArray(array);


    }
   // führt das Linearsortsvorgang und gibt result zurück 
    static int Search(int[] array, int key)
    {
        var result = -1;

        for(int i = 0; i < array.Length; i++)
        {

            if(  key == array[i])
            {

                result = i;
                break;
            }
            
        }




        return result;


    }


    
    
    static void PrintArray(int [] array){


        foreach (var element in array)
        {
            
            
            Console.Write(element + " ");
        }
        
        
        
        Console.WriteLine();
    
    
}
    
    
}