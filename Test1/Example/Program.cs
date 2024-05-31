
Random random = new Random();
List<int> numbers = new List<int>();

Console.Write("Enter the number of random: ");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int randomNumber = random.Next(1, 11);
    numbers.Add(randomNumber);
}

Console.WriteLine("\nRandom Numbers: ");

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine($"List[{i}] = {numbers[i]}");
}

Console.Write("\nMissing Numbers: ");

for (int i = 1; i <= 10; i++)
{
    if (!numbers.Contains(i))
    {
        Console.Write($"{i} ");
    }
}

Console.Write("\nRepeating Numbers: ");
for (int i = 1; i <= 10; i++)
{
    int frequency = numbers.FindAll(x => x == i).Count;
    if (frequency > 1)
    {
        Console.Write($"{i} ");

    }
}
Console.ReadKey();