// Напишите программу, которая заполнит спирально массив 4 на 4

     static string[,] spiralFill (string[,] numsFilled)
    {
        int i;
        int j;
        int m ;
    
        int rowLenght = numsFilled.GetLength(0);
        int colLenght = numsFilled.GetLength(1);

        string[] values = new string[rowLenght * colLenght];                   //линейный массив значений

        int plugLenght = (rowLenght * colLenght).ToString().Length;
        
        for (i = 0; i < values.Length; i++)                                    //заполнение форматированными значениями     
        {
            string nulls =  new String('0', plugLenght - i.ToString ().Length );
            values[i] =  nulls + i.ToString ();
        }
        
        int iterations;                                                        //количество обходов массива по кругу     
        
        if (rowLenght < colLenght)
        {
            iterations = Convert.ToInt32(Math.Truncate((Decimal)rowLenght/2));
        }
        
        else
        {
            iterations = Convert.ToInt32(Math.Truncate((Decimal)colLenght/2));
        }
            
        int fillNum = 0;
        
        for ( m = 0; m < iterations ; m++)                                     //заполнение масива по спирали    
        {
            i = 0 + m;
            
            for (j = 0 + m; j < colLenght - 1 - m; j++ )                       //верхняя строка
            {                  
                numsFilled[i,j] = values[fillNum];
                fillNum++;
            }
            
            j = colLenght - 1 - m;
            
            for (i = 0 + m; i < rowLenght - 1 - m; i++ )                       //правый столбец
            {
                numsFilled[i,j] = values[fillNum];
                fillNum++;
            }
            
            i = rowLenght - 1 - m;
            
            for (j = colLenght - 1 - m ;  j > 0 + m ;  j-- )                   //нижняя строка
            {
                numsFilled[i,j] = values[fillNum];
                fillNum++;
            }
            
            j = 0 + m;
            
            for (i = rowLenght - 1 - m ; i > 0 + m ; i-- )                      //левый столбец
            {
                numsFilled[i,j] = values[fillNum];
                fillNum++;
            }
        }
       
        if ( colLenght % 2 != 0 && colLenght <= rowLenght  )                     //заполнение незамкнутого столбца
        {
            j =  ((colLenght - 1) / 2) ;
            
            for (i = iterations ; i < rowLenght - iterations ; i++ )
            {
                numsFilled[i,j] = values[fillNum];
                fillNum++;
            }   
        }
        
        else if ( rowLenght % 2 != 0 && rowLenght < colLenght )                  //заполнение незамкнутой строки
        {
            i =  ((rowLenght - 1) / 2) ;
            
            for (j = iterations ; j < colLenght - iterations ; j++ )
            {
                numsFilled[i,j] = values[fillNum];
                fillNum++;
            }
        }
        return  numsFilled;
    }

        int m;                                //вывод
        int n;
        
        string tmp = string.Empty;

        Console.WriteLine("введите целым числом большим или равным 2 размер массива по измерению 0 (при пустом или неверном вводе размер будет принят за 4)):");

        tmp =  Console.ReadLine();

        bool check = int.TryParse(tmp, out m);

        if (check == false || m < 2)
        {
            m = 4;
        }

        tmp = string.Empty;

        Console.WriteLine("введите целым числом большим или равным 2 размер массива по измерению 1 (при пустом или неверном вводе размер будет принят за 4)):");

        tmp =  Console.ReadLine();

        check = int.TryParse(tmp, out n);

        if (check == false || n < 2)
        {
            n = 4;
        }

        string[,] nums =   new string[m,n];                                     

        Console.WriteLine("спиральный массив :");
        Console.WriteLine();

        string[,] numsFilled = spiralFill(nums);
        
        for (int i = 0; i < numsFilled.GetLength(0) ; i++ )
        {
            for (int j = 0; j < numsFilled.GetLength(1) ; j++ )
            {
                Console.Write(numsFilled[i,j]+" ");
            }
        Console.WriteLine();
        }