using System.Globalization;


Console.OutputEncoding = System.Text.Encoding.UTF8;

RunApp();

static void RunApp()
{
	while (true)
	{
		PrintHeader("ЛАБОРАТОРНАЯ РАБОТА №3 — CS_Basics");
		Console.WriteLine("Выберите блок задач (только чётные задачи):");
		Console.WriteLine("1 — Переменные и операторы");
		Console.WriteLine("2 — Условные операторы (if/else, switch)");
		Console.WriteLine("3 — Циклы (while, do-while, for)");
		Console.WriteLine("4 — Массивы");
		Console.WriteLine("5 — Функции и методы");
		Console.WriteLine("0 — Выход из программы");

		int block = ReadInt("Введите номер блока: ", 0, 5);

		switch (block)
		{
			case 0:
				Console.WriteLine("До встречи!");
				return;
			case 1:
				Block1();
				break;
			case 2:
				Block2();
				break;
			case 3:
				Block3();
				break;
			case 4:
				Block4();
				break;
			case 5:
				Block5();
				break;
		}
	}
}

// ---------------------- Блок 1: Переменные и операторы ----------------------
static void Block1()
{
	while (true)
	{
		PrintHeader("Блок 1 — Переменные и операторы (только чётные: 2, 4, 6)");
		Console.WriteLine("2 — Индекс массы тела (ИМТ)");
		Console.WriteLine("4 — Перевод времени (секунды -> чч:мм:сс)");
		Console.WriteLine("6 — Цена со скидкой");
		Console.WriteLine("0 — Вернуться в главное меню");

		int choice = ReadInt("Введите номер задачи: ", 0, 6);
		if (choice == 0) return;

		switch (choice)
		{
			case 2:
				Task1_2_BMI();
				break;
			case 4:
				Task1_4_Time();
				break;
			case 6:
				Task1_6_Discount();
				break;
			default:
				Console.WriteLine("Доступны только задачи 2, 4, 6.");
				Pause();
				break;
		}
	}
}

static void Task1_2_BMI()
{
	PrintTask("Блок 1, задача 2: Индекс массы тела (ИМТ)");
	double heightCm = ReadDouble("Введите рост (в сантиметрах): ", 30, 300);
	double weightKg = ReadDouble("Введите вес (в килограммах): ", 1, 500);
	double heightM = heightCm / 100.0;
	double bmi = weightKg / (heightM * heightM);
	Console.WriteLine($"ИМТ: {Math.Round(bmi, 1)}");
	Pause();
}

static void Task1_4_Time()
{
	PrintTask("Блок 1, задача 4: Перевод времени (секунды -> чч:мм:сс)");
	int seconds = ReadInt("Введите количество секунд (>= 0): ", 0);
	int h = seconds / 3600;
	int m = (seconds % 3600) / 60;
	int s = seconds % 60;
	Console.WriteLine($"Результат: {h:00}:{m:00}:{s:00}");
	Pause();
}

static void Task1_6_Discount()
{
	PrintTask("Блок 1, задача 6: Цена со скидкой");
	double price = ReadDouble("Введите цену: ", 0);
	double discount = ReadDouble("Введите размер скидки в % (0..100): ", 0, 100);
	double finalPrice = price * (1 - discount / 100.0);
	Console.WriteLine($"Итоговая цена: {finalPrice:F2}");
	Pause();
}

// ---------------------- Блок 2: Условные операторы ----------------------
static void Block2()
{
	while (true)
	{
		PrintHeader("Блок 2 — Условные операторы (только чётные: 2, 4, 6)");
		Console.WriteLine("2 — Тип треугольника");
		Console.WriteLine("4 — Оценка по числу (switch)");
		Console.WriteLine("6 — Конвертация валют (рубль -> USD/GBP/EUR)");
		Console.WriteLine("0 — Вернуться в главное меню");

		int choice = ReadInt("Введите номер задачи: ", 0, 6);
		if (choice == 0) return;

		switch (choice)
		{
			case 2: Task2_2_Triangle(); break;
			case 4: Task2_4_GradeSwitch(); break;
			case 6: Task2_6_CurrencySwitch(); break;
			default:
				Console.WriteLine("Доступны только задачи 2, 4, 6.");
				Pause();
				break;
		}
	}
}

static void Task2_2_Triangle()
{
    PrintTask("Блок 2, задача 2: Тип треугольника");
    double a = ReadDouble("Сторона a: ", 1);
    double b = ReadDouble("Сторона b: ", 1);
    double c = ReadDouble("Сторона c: ", 1);

    bool possible = a + b > c && a + c > b && b + c > a;
    if (!possible)
    {
        Console.WriteLine("Треугольник с такими сторонами не существует.");
        Pause();
        return;
    }


    if (a == b && b == c)
        Console.WriteLine("Тип: равносторонний");
    else if ((a == b) || (a == c) || (b == c))
		Console.WriteLine("Тип: равнобедренный");
	else
		Console.WriteLine("Тип: разносторонний");

	Pause();
}

static void Task2_4_GradeSwitch()
{
	PrintTask("Блок 2, задача 4: Оценка по числу (switch)");
    int grade = ReadInt("Введите оценку (1..5): ", 1, 5);
    string text = "Неизвестно";
    if (grade == 1)
    {
        text = "Плохо";
    }
    else if (grade == 2)
    {
        text = "Неудовлетворительно";
    }
    else if (grade == 3)
    {
        text = "Удовлетворительно";
    }
    else if (grade == 4)
    {
        text = "Хорошо";
    }
    else if (grade == 5)
    {
        text = "Отлично";
    }
	Console.WriteLine($"Результат: {text}");
	Pause();
}

static void Task2_6_CurrencySwitch()
{
	PrintTask("Блок 2, задача 6: Конвертация валют (RUB -> USD/GBP/EUR)");
	const double USD = 0.3338;
	const double EUR = 0.2884;
	const double GBP = 0.2511;

	double rub = ReadDouble("Введите сумму в рублях: ", 0);
	Console.Write("Выберите валюту (USD/EUR/GBP): ");
	string code = Console.ReadLine().ToUpperInvariant();
    if (code != "USD" && code != "EUR" && code != "GBP")
    {
        Console.WriteLine("Неизвестная валюта. Допустимо: USD, EUR, GBP.");
        Pause();
        return;
    }
    double result = 0;
    if (code == "USD")
    {
        result = rub * USD;
    }
    if (code == "EUR")
    {
        result = rub * EUR;
    }
    if (code == "GBP")
    {
        result = rub * GBP;
    }

	Console.WriteLine($"Результат: {result:F2} {code}");

	Pause();
}

// ---------------------- Блок 3: Циклы ----------------------
static void Block3()
{
	while (true)
	{
		PrintHeader("Блок 3 — Циклы (только чётные: 2, 4, 6)");
		Console.WriteLine("2 — Переворот числа");
		Console.WriteLine("4 — Максимальное нечётное число в [a, b]");
		Console.WriteLine("6 — Арифметическая прогрессия и сумма");
		Console.WriteLine("0 — Вернуться в главное меню");

		int choice = ReadInt("Введите номер задачи: ", 0, 6);
		if (choice == 0) return;

		switch (choice)
		{
			case 2: Task3_2_Reverse(); break;
			case 4: Task3_4_MaxOddInRange(); break;
			case 6: Task3_6_AP(); break;
			default:
				Console.WriteLine("Доступны только задачи 2, 4, 6.");
				Pause();
				break;
		}
	}
}

static void Task3_2_Reverse()
{
	PrintTask("Блок 3, задача 2: Переворот числа");
	long n = ReadLong("Введите целое число: ");
	bool neg = n < 0;
	long x = Math.Abs(n);
	long rev = 0;
	if (x == 0) rev = 0;
	while (x > 0)
	{
		long d = x % 10;
		rev = rev * 10 + d;
		x = x / 10;
	}
	if (neg) rev = -rev;
	Console.WriteLine($"Результат: {rev}");
	Pause();
}

static void Task3_4_MaxOddInRange()
{
	PrintTask("Блок 3, задача 4: Максимальное нечётное число в диапазоне [a, b]");
	long a = ReadLong("Введите a: ");
    long b = ReadLong("Введите b: ");
    long maxOdd = a;
    for(long i = a; i <= b; ++i){
        if(i % 2 != 0 && i > maxOdd){
            maxOdd = i;
        }
    }
	Console.WriteLine($"Максимальное нечётное: {maxOdd}");
	Pause();
}

static void Task3_6_AP()
{
	PrintTask("Блок 3, задача 6: Арифметическая прогрессия");
	int n = ReadInt("Введите количество членов n (>0): ", 1);
	double a1 = ReadDouble("Введите первый член: ");
	double d = ReadDouble("Введите шаг прогрессии: ");

	double sum = 0;
	Console.WriteLine("Члены прогрессии:");
	for (int i = 0; i < n; i++)
	{
		double ai = a1 + i * d;
		sum = sum + ai;
		Console.Write(ai + (i < n - 1 ? ", " : "\n"));
	}
	Console.WriteLine($"Сумма: {sum}");
	Pause();
}

// ---------------------- Блок 4: Массивы ----------------------
static void Block4()
{
	while (true)
	{
		PrintHeader("Блок 4 — Массивы (только чётные: 2, 4, 6)");
		Console.WriteLine("2 — Второй по величине элемент и его индекс");
		Console.WriteLine("4 — Чётные элементы по столбцам (в 2D массиве)");
		Console.WriteLine("6 — Максимумы на диагоналях матрицы и их сумма");
		Console.WriteLine("0 — Вернуться в главное меню");

		int choice = ReadInt("Введите номер задачи: ", 0, 6);
		if (choice == 0) return;

		switch (choice)
		{
			case 2: Task4_2_SecondLargest(); break;
			case 4: Task4_4_EvenPerColumn(); break;
			case 6: Task4_6_DiagonalsMaxAndSum(); break;
			default:
				Console.WriteLine("Доступны только задачи 2, 4, 6.");
				Pause();
				break;
		}
	}
}

static void Task4_2_SecondLargest()
{
	PrintTask("Блок 4, задача 2: Второй по величине элемент");
	int n = ReadInt("Введите размер массива (>=2): ", 2);
	var rnd = new Random();
	int[] arr = new int[n];
	for (int i = 0; i < n; i++) arr[i] = rnd.Next(1, 101);

	Console.WriteLine("Массив: " + string.Join(", ", arr));

	// Поиск второго по величине (отличного от максимума)
	int max = int.MinValue, second = int.MinValue;
	int maxIdx = -1, secondIdx = -1;
	for (int i = 0; i < n; i++)
	{
		int v = arr[i];
		if (v > max)
		{
			second = max; 
			secondIdx = maxIdx;
			
			max = v; 
			maxIdx = i;
		}
		else if (v < max && v > second)
		{
			second = v; secondIdx = i;
		}
	}

	if (secondIdx == -1)
		Console.WriteLine("В массиве нет второго по величине отличного значения (все элементы равны или только один уникальный максимум).");
	else
		Console.WriteLine($"Второй по величине элемент: {second}, индекс: {secondIdx}");

	Pause();
}

static void Task4_4_EvenPerColumn()
{
	PrintTask("Блок 4, задача 4: Чётные элементы по столбцам");
	int rows = ReadInt("Введите число строк (>0): ", 1);
	int cols = ReadInt("Введите число столбцов (>0): ", 1);
	var rnd = new Random();
	int[,] m = new int[rows, cols];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < cols; j++)
			m[i, j] = rnd.Next(1, 101);

	Console.WriteLine("Матрица:");
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < cols; j++)
			Console.Write(m[i, j].ToString().PadLeft(4));
		Console.WriteLine();
	}

	int[] evenCounts = new int[cols];
	for (int j = 0; j < cols; j++)
	{
		int cnt = 0;
		for (int i = 0; i < rows; i++) if (m[i, j] % 2 == 0) cnt++;
		evenCounts[j] = cnt;
	}
	int maxCol = 0;
	for (int j = 1; j < cols; j++) if (evenCounts[j] > evenCounts[maxCol]) maxCol = j;

	Console.WriteLine("Кол-во чётных по столбцам: " + string.Join(", ", evenCounts));
	Console.WriteLine($"Столбец с максимальным числом чётных: {maxCol} (считая с 0), значение = {evenCounts[maxCol]}");
	Pause();
}

static void Task4_6_DiagonalsMaxAndSum()
{
	PrintTask("Блок 4, задача 6: Максимумы на диагоналях");
	int n = ReadInt("Введите размер квадратной матрицы n (>0): ", 1);
	var rnd = new Random();
	int[,] m = new int[n, n];
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
			m[i, j] = rnd.Next(1, 101);

	Console.WriteLine("Матрица:");
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			Console.Write(m[i, j].ToString().PadLeft(4));
		Console.WriteLine();
	}

	int maxMain = int.MinValue, maxAnti = int.MinValue;
	for (int i = 0; i < n; i++)
	{
		if (m[i, i] > maxMain) maxMain = m[i, i];
		int j = n - 1 - i;
		if (m[i, j] > maxAnti) maxAnti = m[i, j];
	}
	Console.WriteLine($"Max на главной диагонали: {maxMain}");
	Console.WriteLine($"Max на побочной диагонали: {maxAnti}");
	Console.WriteLine($"Сумма максимумов: {maxMain + maxAnti}");
	Pause();
}

// ---------------------- Блок 5: Функции ----------------------
static void Block5()
{
	while (true)
	{
		PrintHeader("Блок 5 — Функции (чётные: 2, 4, 6, 8)");
		Console.WriteLine("2 — Генерация массива GenerateArray");
		Console.WriteLine("4 — Рекурсивная сумма цифр DigitSum");
		Console.WriteLine("6 — Разделение числа Split");
		Console.WriteLine("8 — Длины строк GetLengths");
		Console.WriteLine("0 — Вернуться в главное меню");

		int choice = ReadInt("Введите номер задачи: ", 0, 8);
		if (choice == 0) return;

		switch (choice)
		{
			case 2: Demo_Block5_2_GenerateArray(); break;
			case 4: Demo_Block5_4_DigitSum(); break;
			case 6: Demo_Block5_6_Split(); break;
			case 8: Demo_Block5_8_GetLengths(); break;
			default:
				Console.WriteLine("Доступны только задачи 2, 4, 6, 8.");
				Pause();
				break;
		}
	}
}

// Реализации функций Блока 5
static int[] GenerateArray(int count, int min, int max)
{
	if (count < 0) return [];
	if (min > max) (min, max) = (max, min);
	var rnd = new Random();
	int[] arr = new int[count];
	for (int i = 0; i < count; i++) arr[i] = rnd.Next(min, max + 1);
	return arr;
}

static int DigitSum(int number)
{
	number = Math.Abs(number);
	if (number < 10) return number;
	return number % 10 + DigitSum(number / 10);
}

static void Split(double number, out int whole, out double fraction)
{
	whole = (int)Math.Truncate(number);
	fraction = Math.Abs(number - whole);
}

static int[] GetLengths(params string[] strings)
{
	int[] res = new int[strings.Length];
	for (int i = 0; i < strings.Length; i++) res[i] = strings[i]?.Length ?? 0;
	return res;
}

// Демо-вызовы для задач блока 5 (ввод/вывод)
static void Demo_Block5_2_GenerateArray()
{
	PrintTask("Блок 5, задача 2: GenerateArray");
	int count = ReadInt("Введите размер массива (>=0): ", 0);
	int min = ReadInt("Введите минимум: ");
	int max = ReadInt("Введите максимум: ");
	var arr = GenerateArray(count, min, max);
	Console.WriteLine("Сгенерированный массив: " + string.Join(", ", arr));
	Pause();
}

static void Demo_Block5_4_DigitSum()
{
	PrintTask("Блок 5, задача 4: DigitSum");
	int n = ReadInt("Введите целое число: ");
	Console.WriteLine($"Сумма цифр: {DigitSum(n)}");
	Pause();
}

static void Demo_Block5_6_Split()
{
	PrintTask("Блок 5, задача 6: Split");
	double x = ReadDouble("Введите число: ");
	Split(x, out int whole, out double frac);
	Console.WriteLine($"Целая часть: {whole}, дробная часть (модуль): {frac}");
	Pause();
}

static void Demo_Block5_8_GetLengths()
{
	PrintTask("Блок 5, задача 8: GetLengths");
	Console.WriteLine("Введите строки через запятую: ");
	string line = Console.ReadLine() ?? string.Empty;
	string[] items = line.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
	var lengths = GetLengths(items);
	Console.WriteLine("Длины: " + string.Join(", ", lengths));
	Pause();
}

// ---------------------- Утилиты ввода/вывода ----------------------
static int ReadInt(string prompt, int? min = null, int? max = null)
{
	while (true)
	{
		Console.Write(prompt);
		string? s = Console.ReadLine();
		if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out int v))
		{
			if (min.HasValue && v < min.Value) { Console.WriteLine($"Число должно быть >= {min.Value}."); continue; }
			if (max.HasValue && v > max.Value) { Console.WriteLine($"Число должно быть <= {max.Value}."); continue; }
			return v;
		}
		Console.WriteLine("Некорректный ввод, попробуйте ещё раз.");
	}
}

static long ReadLong(string prompt, long? min = null, long? max = null)
{
	while (true)
	{
		Console.Write(prompt);
		string? s = Console.ReadLine();
		if (long.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out long v))
		{
			if (min.HasValue && v < min.Value) { Console.WriteLine($"Число должно быть >= {min.Value}."); continue; }
			if (max.HasValue && v > max.Value) { Console.WriteLine($"Число должно быть <= {max.Value}."); continue; }
			return v;
		}
		Console.WriteLine("Некорректный ввод, попробуйте ещё раз.");
	}
}

static double ReadDouble(string prompt, double? min = null, double? max = null)
{
	while (true)
	{
		Console.Write(prompt);
		string? s = Console.ReadLine()?.Replace(',', '.'); // допускаем запятую
        if (double.TryParse(s, out double v))
        {
            if (min.HasValue && v < min.Value - 1e-12) { Console.WriteLine($"Число должно быть >= {min.Value}."); continue; }
            if (max.HasValue && v > max.Value + 1e-12) { Console.WriteLine($"Число должно быть <= {max.Value}."); continue; }
            return v;
        }
		Console.WriteLine("Некорректный ввод, попробуйте ещё раз.");
	}
}

static void PrintHeader(string title)
{
	Console.WriteLine();
	Console.WriteLine(new string('=', Math.Max(8, title.Length + 4)));
	Console.WriteLine("  " + title);
	Console.WriteLine(new string('=', Math.Max(8, title.Length + 4)));
}

static void PrintTask(string title)
{
	Console.WriteLine();
	Console.WriteLine(new string('-', Math.Max(8, title.Length + 4)));
	Console.WriteLine("  " + title);
	Console.WriteLine(new string('-', Math.Max(8, title.Length + 4)));
}

static void Pause()
{
	Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
	Console.ReadKey(true);
}
