//      Массивы
//      Практическая работа
//
//  Цель:   научиться использовать одномерные и двумерные массивы
//          закрепить знания по применению циклов


byte exit = 0;
while (exit != 1)
{
    // Вывод меню и выбор задачи

    Console.WriteLine($"{"\tМЕНЮ:  \n1 - Случайная матрица \n2 - Наименьший элемент в последовательности \n3 - Игра «Угадай число» \n0 - Выход \n\n=="}");
    string inputNum = Console.ReadLine();
    byte num = byte.Parse(inputNum);

    if (num >= 0 && num <= 3);
    {
        switch (num)
        {
            case 0:     // Выход из программы
                
                exit = 1;  
                break;

            case 1:    // Случайная матрица

                Console.Clear();
                Console.Write("Создание случайной матрицы по заданным параметрам");                
                Console.Write("\n\nВведите количество строк:    ");
                int line = int.Parse(Console.ReadLine());
                Console.Write("\nВведите количество столбцов: ");
                int column = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                int[,] matrix = new int[line, column];
                int[] sumLine = new int[line];
                int sum = 0;    
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Random rand = new Random();
                        matrix[i, j] = rand.Next(1000);
                        sumLine[i] += matrix[i,j];                        
                        Console.Write($"{matrix[i, j],4}  ");
                    }
                    //sumColumn[i] += matrix[i, j];
                    Console.WriteLine($" ==> сумма элементов строки: {sumLine[i]}");
                    sum += sumLine[i];
                }
                
                Console.WriteLine($"\n\n Сумма ВСЕХ элементов матрицы: {sum}");
                Console.ReadKey();

                break;

            case 2:     // Наименьший элемент в последовательности

                Console.Clear();
                
                Console.Write($"Определение наименьшего числа в заданной последовательности \n\nВведите длину последовательности целых чисел: ");
                int quantity = int.Parse(Console.ReadLine());
                int[] array = new int[quantity];
                
                Console.Write($"\nДалее, отвечая на запросы программы, \nВым необходимо ввести целые числа (положительные или отрицательные) \n\n");

                
                for (int i = 0; i < quantity; i++)
                {
                    try
                    {
                        Console.Write($"Введите  {i + 1}-й элемент последовательности: ");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Write($"\nК сожалению Вы ошиблись. Повторите ввод \n");
                        i--;
                        continue;
                    }                                       
                }

                Array.Sort(array);

                Console.WriteLine($"\nНаименьший элемент в заданной последовательности : {array[0]}");

                Console.ReadKey();

                break;

            case 3:     // Игра «Угадай число»

                Console.Clear();
                Console.Write($"Игра «Угадай число»\n\nВведите максимальное число: ");
                int maxNum = int.Parse(Console.ReadLine());
                Random randomize = new Random();
                int randomIntResult = randomize.Next(maxNum + 1);
                
                Console.Write(randomIntResult);

                while (true)
                {
                    int inputNumber = 0;
                    
                    try
                    {
                        Console.Write($"\nВведите целое число из диапазона от 0 до {maxNum}: ");
                        inputNumber = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"\n\nСпасибо за игру. Загаданное число: {randomIntResult}");
                        break;
                    }
                    if (inputNumber == randomIntResult)
                    {
                        Console.Write("Поздравляю, Вы угадали загаданное число!");
                        break;
                    }
                    else
                    {
                        if (inputNumber > randomIntResult)
                        {
                            Console.WriteLine("\nВведённое Вами число БОЛЬШЕ загаданного");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("\nВведённое Вами число МЕНЬШЕ загаданного");
                            continue;
                        }
                    }
                }

                Console.ReadKey();
                
                break;
        }

    }
    Console.Clear();
}