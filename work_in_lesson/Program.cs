// Пример №1

//string GetNum4()
//            {
//            Console.Write("введите координату х ");
//            int x = int.Parse (Console.ReadLine());
//            Console.Write("введите координату y ");
//            int y = int.Parse (Console.ReadLine());
//            int res;
//            if (x>0 && y>0) res=1;
//            else if (x>0 && y<0) res=2;
//            else if (x<0 && y<0) res=3;        
//            else if (x<0 && y>0) res=4;   
//            else res=0;
//
//            if (res!=0) return $"это четверть с номером {res}";
//            else return "точка лежит на осях";
//            }
//        try
//            {
//                Console.WriteLine(GetNum4());
//            }
//        catch
//            {
//              Console.WriteLine("Надо было вводить именно целые числа");  
//            }

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

string getDistance()
{
    Console.Write("Введите X координату первой точки ");
    int firstX = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Y координату первой точки ");
    int firstY = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите X координату второй точки ");
    int secondX = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Y координату второй точки ");
    int secondY = Convert.ToInt32(Console.ReadLine());
    double distance = Math.Round(Math.Sqrt(Math.Pow(firstX-secondX, 2)+Math.Pow(firstY-secondY, 2)), 2);
    return $"расстояние между двумя точками в 2D пространстве {distance}";
}
try
{
   Console.WriteLine(getDistance());
}
catch
{
    Console.WriteLine("Необходимо вводить коортинаты целыми числами");    
}

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

string numdersKV()
 {
    Console.Write("Введите положительное число ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i=1;
            string res = string.Empty;   //пустая строка
            while (i <= N)
            {
                res = res + i*i+", ";
                i=i+1;
                 
            }
    return res;
 }
  Console.WriteLine(numdersKV());


