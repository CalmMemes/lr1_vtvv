class Program
{

    static void Main(string[] args)
    {
        Func<Action<int, int>, bool> func = GetTrue; //создание делегата 
        Action<int, int> action = Draw; //инициализация делегата
        func.Invoke(action); //вызов делегата
        func = GetFalse; // инициализация делегата
        func.Invoke(action); //вызов делегата

    }

    static void Draw(int x, int y) //метод вывода на экран
    {
        Console.WriteLine($"{x} and {y}");

    }
    static bool GetTrue(Action<int, int> draw) //метод возвращающий «true»
    {
        draw.Invoke(5, 6);
        return true;
    }
    static bool GetFalse(Action<int, int> draw) //метод возвращающий «false»
    {
        draw.Invoke(10, 6);
        return false;
    }

}
