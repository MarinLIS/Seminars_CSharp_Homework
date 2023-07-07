// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void CreatArr (int [,,] array)
{
  int [] arrToCheck = new int [array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
  int numToChange; // ввожу число, в которое буду сохранять первое из повторяющихся значений
  for (int i = 0; i < arrToCheck.Length; i++)
  {
    arrToCheck[i] = new Random().Next(10,40+1); // заполняю массив двухзначными рандомными числами
    // numToChange = arrToCheck[i];
    if (i>=1) // счетчик для i начинается с 1
    {
      numToChange = arrToCheck[i];
      for (int j = 1; j < i; j++) // счетчик j начинается со второго элемента
      {
        while (arrToCheck[i] == arrToCheck[j])// сравниваю по два числа, если равны меняю на рандомное число и сбрасываю счетчик j
        {
          arrToCheck[i] = new Random().Next(10,40+1);
          j=0;
          numToChange = arrToCheck[i];
        }
      }
    }
  }  
  int count = 0; // перекладываю значения с одномерного массива в трехмерный
  for (int n = 0; n < array.GetLength(0); n++)
  {
    for (int k = 0; k < array.GetLength(1); k++)
    {
      for (int m = 0; m < array.GetLength(2); m++)
      {
        array[n,k,m] = arrToCheck[count];
        count++;
      }
    }
  }
}    
    


void ArrToShow (int [,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int m = 0; m < arr3D.GetLength(2); m++)
            {
                Console.Write (arr3D [i,j,m] + " ");
                
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void DefineArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      
      for (int m = 0; m < array3D.GetLength(2); m++)
      {
        Console.Write( $"({i},{j},{m})={array3D[i,j,m]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.WriteLine ("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся"+
"двузначных чисел. Напишите программу, которая будет построчно выводить массив,"+
"добавляя индексы каждого элемента. Массив размером 2 x 2 x 2 ");

int num_rows = 2;
int num_cols = 2;
int num_cols2 = 2;

int [,,] arrToWork = new int [num_rows, num_cols, num_cols2];
CreatArr (arrToWork);
ArrToShow(arrToWork);
DefineArray(arrToWork);
Console.ReadKey(true);

 








