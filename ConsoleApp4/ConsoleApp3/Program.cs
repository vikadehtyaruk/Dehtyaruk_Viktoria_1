//task1
try
{
    Console.WriteLine("введiть кiлькiсть мiсць на стоянцi");
    int n = Convert.ToInt32(Console.ReadLine());
    List<int> cars = new List<int>(n);
    static void Main(List<int> cars, int n)
    {
        Console.WriteLine("якщо бажаєте поставити машину натиснiть 1,якщо бажаєте забрати машину натиснiть 2");
        int a = Convert.ToInt32(Console.ReadLine());
        if (n == cars.Count)
        {
            Console.WriteLine("стоянка переповнена");
            Console.WriteLine("яку машину ви бажаєте забрати?");
            int с = Convert.ToInt32(Console.ReadLine());
            if (cars.Contains(с))
            {
                cars.Remove(с);
            }
            else
            {
                Console.WriteLine("такої машини немає");
            }
            Console.WriteLine("Машини на стоянцi: ");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
        else
        {
            if (a == 1)
            {
                Console.WriteLine("яку машину ви бажаєте поставити?");
                int b = Convert.ToInt32(Console.ReadLine());
                cars.Add(b);
                Console.WriteLine("Машини на стоянцi: ");
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            if (a == 2)
            {
                Console.WriteLine("яку машину ви бажаєте забрати?");
                int с = Convert.ToInt32(Console.ReadLine());
                if (cars.Contains(с))
                {
                    cars.Remove(с);
                }
                else
                {
                    Console.WriteLine("такої машини немає");
                }
                Console.WriteLine("Машини на стоянцi: ");
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
    for (int i = 0; i < 100; i++)
    {
        Main(cars, n);
    }
}
catch 
{
    Console.WriteLine("Неправильно введенi данi");
}
Console.ReadKey();