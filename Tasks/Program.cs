// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Menu();

void Menu() //Меню выбора задачи.
{
    Console.Clear();
    Console.WriteLine("Меню выбора задачи.");
    Console.WriteLine("Введите цифру для выбора задачи:");
    Console.WriteLine("1 - Программа для нахождения суммы натуральных элементов в промежутке от M до N.");
    Console.WriteLine("2 - Программа для вычисления функции Аккермана с помощью рекурсии.");

    int result = PutNumber("Введите номер задачи");

      switch (result)
      {
        case 1:
          Console.Clear();
          Task_66();
          break;

        case 2:
          Console.Clear();
          Task_68();
          break;

        default:
          Console.Clear();
          Console.WriteLine("Номер задачи введен некорректно. Повторите попытку.");
          Console.ReadLine();
          break;
    }
  }

int PutNumber(string message)
{
  System.Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int SumNaturNumber(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;           
    else if (N == 0) return (M * (M + 1)) / 2;      
    else if (M == N) return M;                       
    else if (M < N) return N + SumNaturNumber(M, N - 1); 
    else return N + SumNaturNumber(M, N + 1);            
}

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));

  // if (m == 0)
  //   return n + 1;
  // else
  //   if ((m != 0) && (n == 0))
  //     return Akkerman(m - 1, 1);
  //   else
  //     return Akkerman(m - 1, Akkerman(m, n - 1));
}

void Task_66()
{  
  System.Console.WriteLine(SumNaturNumber(PutNumber("Введите M: "),PutNumber("Введите N: ")));
}

void Task_68()
{

//System.Console.WriteLine(Akkerman(PutNumber("Введите m: "),PutNumber("Введите n: ")));

int result = Akkerman(PutNumber("Введите m: "),PutNumber("Введите n: "));

Console.Write($"A(m,n) = {result} ");

}


 