Random random = new Random();
int target = random.Next(1, 101);
int guess = 0;
int attempts = 0;

Console.WriteLine("猜一个 1-100 之间的数字");

while (guess != target)
{
    Console.Write("输入数字: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("请输入有效的数字");
        continue;
    }

    attempts++;

    if (guess < target)
        Console.WriteLine("太小了");
    else if (guess > target)
        Console.WriteLine("太大了");
    else
        Console.WriteLine($"猜中了！用了 {attempts} 次");
}

Console.ReadKey();