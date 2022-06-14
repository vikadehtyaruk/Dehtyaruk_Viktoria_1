//task2
using System.Text.Json;
using Newtonsoft.Json;
try
{
    var dictionary = new Dictionary<int, int>();
    Console.WriteLine("введiть значення");
    int a;
    for (int b = 0; b < 6; b++)
    {
        Console.Write("елемент {0} ", b);
        a = Convert.ToInt32(Console.ReadLine());
        dictionary.Add(b, a);
    }
    var method = dictionary.Where(i => dictionary.Any(t => t.Key != i.Key && t.Value == i.Value))
        .ToDictionary(i => i.Key, i => i.Value);
    foreach (var person1 in method)
        dictionary.Remove(person1.Key);
    foreach (var person in dictionary)
    {
        Console.WriteLine($"ключ: {person.Key}  значення: {person.Value}");
    }
    var json = JsonConvert.SerializeObject(dictionary);
    File.WriteAllText(@"D:\dict.json", json);
}
catch
{
    Console.WriteLine("Error");
}
Console.ReadKey();