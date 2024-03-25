using System.Dynamic;
using System.Runtime.CompilerServices;

namespace AnonymousTypeSelect;

/*internal class Program
{
    static void Main(string[] args)
    {
        User[] users =
        {
            new User(){Name = "John", Age = 18, Birthday = new DateOnly(2006, 3, 24), Country = "USA"},
            new User(){Name = "Artur", Age = 33, Birthday = new DateOnly(1991, 5, 17), Country = "Ukraine"},
            new User(){Name = "Su", Age = 16, Birthday = new DateOnly(2008, 7, 30), Country = "Japan"},
            new User(){Name = "George", Age = 44, Birthday = new DateOnly(1980, 12, 30), Country = "Germany"},
        };

        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine(users[i]);
        }

        var elements = users.Select(e => new { e.Name, e.Age }).ToArray();

        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }

    public class User
    {
        public User()
        {
            Id = ++id;
        }
        public string Name { get; set; }
        private static int id = 0;
        public int Id { get; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Name - {Name}, Id - {Id}, Age - {Age}, Birthday - {Birthday}, Country - {Country}";
        }
    }
}*/

/*public class AdditionalTask1
{
    static void Main(string[] args)
    {
        dynamic obj = new ExpandoObject();
        obj.Name = "Oleg";

        obj.Info = (Func<string>)(() => obj.Name );

        Console.WriteLine(obj.Info());
    }
}*/

/*public class AdditionalTask2
{
    static void Main(string[] args)
    {
        Point point = new Point(2, 5);

        Console.WriteLine(point.Show());
    }

}
public partial class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }

}*/

/*public class AdditionalTask3
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] array = new int[30];

        int elementIndex = random.Next(0, array.Length);
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {
            if (i == elementIndex)
            {
                array[i] = number;
                continue;
            }
            array[i] = random.Next(0, 20);
        }

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine($"\n\nКоличество элементов {number} в массиве: {array.CountOfNumber(number)}");
    }

}
public static class Extension
{
    public static int CountOfNumber(this IEnumerable<int> array, int n)
    {
        int count = 0;

        foreach (var item in array)
        {
            if (item == n) count++;
        }

        return count;
    }
}*/

/*public class AdditionalTask5
{
    static void Main(string[] args)
    {
        string s = "Мне нравится С #";
        Console.WriteLine(s.CountNotLetter());

        int a = 12340;

        int[] array = a.NumberToArray();
        
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }
}

public static class MyExtension
{
    public static int CountNotLetter(this string obj)
    {
        int count = 0;
        for (int i = 0; i < obj.Length; i++)
        {
            if (!char.IsLetter(obj[i]))
            {
                count++;
            }
        }
        return count;
    }

    public static int[] NumberToArray(this int number)
    {
        int arraySize = 0;

        for (int i = number; i > 0; i /= 10)
        {
            arraySize++;
        }

        int[] array = new int[arraySize];

        for (int i = number, j = arraySize-1; i > 0; i/=10)
        {
            array[j--] = i % 10;
        }

        return array;
    }
}*/

/*public class AdditionalTask6
{
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix(new float[3, 3]);

        matrix.FillMatrix();

        matrix.Show();

        *//*matrix.MultiplyByNumber(3);

        matrix.Show();*//*

        Matrix matrix2 = new Matrix(new float[3, 3]);

        matrix2.FillMatrix();

        Console.WriteLine("\n\nSECOND MATRIX\n\n");

        matrix2.Show();

        matrix.SumMatrix(matrix2);

        Console.WriteLine("\n\nSUM MATRIX\n\n");

        matrix.Show();

        matrix.MulMatrix(matrix2);

        Console.WriteLine("\n\nMULTIPLIED MATRIX\n\n");

        matrix.Show();
    }

}
public partial class Matrix
{
    public Matrix()
    {
        Array = new float[0, 0];
    }

    public Matrix(float[,] array)
    {
        if (array == null)
        {
            throw new Exception("Array was null!");
        }
        Array = array;
        Rows = Array.GetLength(0);
        Cols = Array.GetLength(1);
    }

    private float[,] Array { get; set; }
    public int Rows { get; private set; }
    public int Cols { get; private set; }
}*/