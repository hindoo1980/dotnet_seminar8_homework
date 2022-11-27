//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] arrCreate ()

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

void ColumnSort ()

    {

        int[,] nums = arrCreate ();

        Console.WriteLine();

        Console.WriteLine("для следующего массива :");

        Console.WriteLine();


        for (int i = 0; i < nums.GetLength(0) ; i++ )

        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
                Console.Write(nums[i,j]+" ");
            }

        Console.WriteLine();

        }


        int temp;

        int rowLenght = nums.GetLength(0);
        int colLenght = nums.GetLength(1);

        
        for (int i = 0; i < rowLenght ; i++ )
        {

            for (int j = 0; j < colLenght ; j++ )
            {
                    for (int k = j + 1; k < colLenght ; k++ )
                    {

                        if (nums[i,j] < nums[i,k])
                        {
                            temp = nums[i,j];

                            nums[i,j] = nums[i,k];

                            nums[i,k] = temp;
                        }


                    }
              
            }

        }


        Console.WriteLine();

        Console.WriteLine("получаем вариант с отсортированными по убыванию строками:");

        Console.WriteLine();


        for (int i = 0; i < nums.GetLength(0) ; i++ )

        {
            for (int j = 0; j < nums.GetLength(1) ; j++ )
            {
                Console.Write(nums[i,j]+" ");
            }

        Console.WriteLine();

        }
    
    }

 ColumnSort ();