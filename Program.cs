Console.Clear();
 string[] ArrayFill;
            Console.WriteLine("Введите массив строк через пробел");
            string line = Console.ReadLine();
            ArrayFill = line.Split(' ');
            var result = new string[ArrayFill .Length];
            var Size = 0;
                     foreach (var value in ArrayFill )
            {
                if (value.Length <= 3)
                {
                    result[Size] = value;
                    Size++;
                 }
            }
            Console.WriteLine($"[{string.Join(", ", result, 0, Size)}]");
            Console.ReadKey(true);
            