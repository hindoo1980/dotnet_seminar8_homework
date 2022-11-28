//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

   static int[,] arrCreate ()

    {
        int m;
        int n;

        Random rndInt = new Random();

        m = rndInt.Next(2, 9);
        n = rndInt.Next(2, 9);

        int[,] nums = new int[m,n];

        for (int i = 0; i < nums.GetLength(0) ; i++ )
        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
                nums[i,j] = rndInt.Next(0, 9);
            }
        }
    
        return nums;
    }
    
    
    static int[,] arrSort (int[,] numsSorted)

    {
           
        int temp;

        int rowLenght = numsSorted.GetLength(0);
        int colLenght = numsSorted.GetLength(1);

        
        for (int i = 0; i < rowLenght ; i++ )
        {

            for (int j = 0; j < colLenght ; j++ )
            {
                    for (int k = j + 1; k < colLenght ; k++ )
                    {

                        if (numsSorted[i,j] < numsSorted[i,k])
                        {
                            temp = numsSorted[i,j];

                            numsSorted[i,j] = numsSorted[i,k];

                            numsSorted[i,k] = temp;
                        }


                    }
              
            }

        }
    
        return numsSorted;
    }
    
        Console.WriteLine();

        Console.WriteLine("для следующего массива :");

        Console.WriteLine();
        
        int[,] nums = arrCreate ();


        for (int i = 0; i < nums.GetLength(0) ; i++ )

        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
                Console.Write(nums[i,j]+" ");
            }

        Console.WriteLine();

        }

        Console.WriteLine();

        Console.WriteLine("получаем вариант с отсортированными по убыванию строками:");

        Console.WriteLine();
        
        int[,] numsSorted = arrSort(nums);
        

        for (int i = 0; i < numsSorted.GetLength(0) ; i++ )

        {
            for (int j = 0; j < numsSorted.GetLength(1) ; j++ )
            {
                Console.Write(numsSorted[i,j]+" ");
            }

        Console.WriteLine();

        }