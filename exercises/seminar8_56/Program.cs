// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
   

     static String findMinRow (int[,] nums)

    {
         
        int rowLenght = nums.GetLength(0);
        int colLenght = nums.GetLength(1);

        String rowsCatch = "1";

        int minRowSumm = 0;
  
        for (int i = 0; i < rowLenght ; i++ )
        {
            int RowSumm = 0;

            for (int j = 0; j < colLenght ; j++ )
            {
                RowSumm = RowSumm + nums[i,j];       
            }

            if (i == 0)
            {
                minRowSumm = RowSumm;
            }

            else
            {
                if (minRowSumm > RowSumm)
                {
                    minRowSumm = RowSumm;
                    rowsCatch = (i + 1).ToString();
                }
                else if (minRowSumm == RowSumm)
                {
                    rowsCatch = rowsCatch + ", " + (i + 1).ToString();
                }
            }

        }
    
        return  rowsCatch;
    }
       

    Console.WriteLine();

    Console.WriteLine("в следующем массиве :");

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

    String end = String.Empty;

    String rows = findMinRow (nums);


    if (rows.Length == 1)
    {
        end = "имеет строка";
    }
    else
    {
        end = "имеют строки";
    }

    Console.WriteLine($"наименьшую сумму элементов {end} {rows}");