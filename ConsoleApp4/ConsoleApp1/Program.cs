// task3
try
{
        Console.WriteLine("введiть число бiльше нуля");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введiть довжину послiдовностi");
        int b = Convert.ToInt32(Console.ReadLine());
        string s10, s9;
        string[] values = new string[b];
        for (int i = 0; i < b; i++)
        {
            Console.WriteLine("Введiть слово, яке складається з великих латинських лiтер");
            values[i] = Convert.ToString(Console.ReadLine());
        }
        s10 = string.Join(" ", values);
        //Console.WriteLine(s10);
        string[] str = s10.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] filteredWords = str.Where(w => w.Length == l).ToArray();
        Array.Sort(filteredWords);
        var orderedPeople = from p in filteredWords orderby p select p;
        Console.WriteLine("впорядкованi слова:");
        foreach (var p in orderedPeople)
            Console.WriteLine(p);
}
catch
{
    Console.WriteLine("Неправильно введенi данi");
}