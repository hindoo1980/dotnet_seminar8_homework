// See https://aka.ms/new-console-template for more information

static int[,] matrixCreate (int m, int n)

    {
        Random rndInt = new Random();

        int[,] matrix = new int[m,n];

        for (int i = 0; i < matrix.GetLength(0) ; i++ )
        {
            for (int j = 0; j < matrix.GetLength(1) ; j++ )
            {
                 matrix[i, j] = rndInt.Next(-17, 17);
            }
        }
      
        return matrix;
    }

    

    static void arrPrint (int[,] matrix)
    {
        string plug = string.Empty;

        for (int i = 0; i < matrix.GetLength(0) ; i++ )
        {
            for (int j = 0; j < matrix.GetLength(1) ; j++ )
            {

                if(matrix[i, j]>=0)
                {
                    plug =" ";
                }

                if(Math.Abs(matrix[i, j]) < 100 && Math.Abs( matrix[i, j]) > 9)
                {
                    plug = plug + " ";
                }

                else if(Math.Abs( matrix[i, j]) < 10)
                {
                    plug = plug + "  ";
                }

                Console.Write($"{plug}{matrix[i, j] } ");

                plug = string.Empty;
            }
            Console.WriteLine();
        }
    }

    
    
    static int[,] matrixMult (int[,] matrix1 , int[,] matrix2)
    {

        int[,] multiMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1) ];
        
        for (int i = 0; i <  matrix1.GetLength(0) ; i++ )
            {
                for (int j = 0; j < matrix2.GetLength(1) ; j++ )
                {
                    for (int k = 0; k < matrix2.GetLength(0) ; k++ )
                    {
                         multiMatrix[i, j] = multiMatrix[i, j] + (matrix1[i,k] * matrix2[k,j]);
                    }
                    
                }
    
            }
            
            return multiMatrix;
    }

    
    int m1;                              
    int n1;
    
    int m2;                              
    int n2;
    
    string tmp = string.Empty;

    Console.WriteLine("введите целым положительным числом больше 0 количество строк матрицы 1:");

    tmp =  Console.ReadLine();

    bool check = int.TryParse(tmp, out m1);

    if (check == false || m1 < 1)
    {
        Console.WriteLine("неверный ввод");
        Environment.Exit(0);
    }
    

    tmp = string.Empty;

    Console.WriteLine("введите целым положительным числом больше 0 количество столбцов матрицы 1:");

    tmp =  Console.ReadLine();

    check = int.TryParse(tmp, out n1);

    if (check == false || n1 < 1)
    {
        Console.WriteLine("неверный ввод");
        Environment.Exit(0);
    }
    
    
    tmp = string.Empty;

    Console.WriteLine("введите целым положительным числом больше 0 количество строк матрицы 2:");

    tmp =  Console.ReadLine();

    check = int.TryParse(tmp, out m2);

    if (check == false || m2 < 1)
    {
        Console.WriteLine("неверный ввод");
        Environment.Exit(0);
    }


    tmp = string.Empty;

    Console.WriteLine("введите целым положительным числом больше 0 количество столбцов матрицы 2:");

    tmp =  Console.ReadLine();

    check = int.TryParse(tmp, out n2);

    if (check == false || n2 < 1)
    {
        Console.WriteLine("неверный ввод");
        Environment.Exit(0);
    }

        
    int[,] matrix1 = matrixCreate (m1,n1) ;
    int[,] matrix2 = matrixCreate (m2,n2) ;
            
    if (matrix1.GetLength(1) !=  matrix2.GetLength(0))
    {     
        Console.WriteLine("матрицы с указанными размерностями невозможно умножить");
    }

    else
    {
        Console.WriteLine("для матрицы:");
        
        Console.WriteLine();
        
        arrPrint (matrix1); 
        
        Console.WriteLine();
        
        Console.WriteLine("и матрицы:");
        
        Console.WriteLine();
        
        arrPrint (matrix2); 
        
        Console.WriteLine();
        
        Console.WriteLine("произведение матриц будет равно матрице:");
        
        Console.WriteLine();
        
        arrPrint (matrixMult(matrix1, matrix2));   
    }