// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

static int[,,] arrCreate ()

    {
        int m;
        int n;
        int f;

        Random rndInt = new Random();

        m = rndInt.Next(2, 5);
        n = rndInt.Next(2, 5);
        f = rndInt.Next(2, 4);

        int[,,] nums3d = new int[m,n,f];

        int[] nums1d = new int[m*n*f];

        int s = rndInt.Next(10, 100 - m*n*f );

        for (int i = 0; i < nums1d.Length; i++)
        {
            nums1d[i] = i+s;
        }

        for (int i = nums1d.Length; i > 0; i--)
        {
            int j = rndInt.Next(i);

            int k = nums1d[j];

            nums1d[j] = nums1d[i - 1];
            
            nums1d[i - 1]  = k;
        }

        s = 0;

        for (int i = 0; i < nums3d.GetLength(0) ; i++ )
        {
            for (int j = 0; j < nums3d.GetLength(1) ; j++ )
            {
                for (int k = 0; k < nums3d.GetLength(2) ; k++ )
                {
                        nums3d[i, j, k] = nums1d[s];
                        s++;
                }
            }
        }
    
        return nums3d;
    }

    void arrPrint ( int[,,] nums3d)
    {
        Console.WriteLine("Сгенерированный маммив и его индексы выведенные по строкам:");
        Console.WriteLine();

        int cHrow = 0;

        for (int k = 0; k < nums3d.GetLength(2) ; k++ )
        {
            for (int i = 0; i < nums3d.GetLength(0) ; i++ )
            {
                for (int j = 0; j < nums3d.GetLength(1) ; j++ )
                {
                    Console.Write($"{nums3d[i, j, k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    arrPrint ( arrCreate ());