try
{
    Console.WriteLine("Введите количество работников:");
    int n=int.Parse(Console.ReadLine());
    Workers[] workers = new Workers[n];
    for (int i = 0; i < n; i++)
    {
        workers[i] = new Workers();
        Console.WriteLine("Вветите фамилию:");
        workers[i].lastName = Console.ReadLine();
        Console.WriteLine("Введите имя:");
        workers[i].firstName = Console.ReadLine();
        Console.WriteLine("Введите отчество:");
        workers[i].patronymic = Console.ReadLine();
        Console.WriteLine("Введите должность:");
        workers[i].position = Console.ReadLine();
        Console.WriteLine("Введите пол:");
        workers[i].gender = Console.ReadLine();
        Console.WriteLine("Введите дату приема на работу(yyyy.mm.dd)");
        string dateWork = Console.ReadLine();
        workers[i].dateWork = DateTime.ParseExact(dateWork, "yyyy.MM.dd", null);

        TimeSpan workExperience = DateTime.Now - workers[i].dateWork;

        if (workExperience.TotalDays / 365 > 10)
        {
            Console.WriteLine("\nДанные о сотруднике:");
            Console.WriteLine("Фамилия: " + workers[i].lastName);
            Console.WriteLine("Имя: " + workers[i].firstName);
            Console.WriteLine("Отчество: " + workers[i].patronymic);
            Console.WriteLine("Должность: " + workers[i].position);
            Console.WriteLine("Пол: " + workers[i].gender);
            Console.WriteLine("Дата приема на работу: " + workers[i].dateWork.ToString("dd.MM.yyyy"));
            Console.WriteLine("Стаж работы: " + workExperience.Days / 365 + " лет.");
        }
        else
        {
            Console.WriteLine("\nСтаж работы меньше 10 лет.");
        }
    }
}


catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Workers
{
    public string lastName;
    public string firstName;
    public string patronymic;
    public string position;
    public string gender;
    public DateTime dateWork;
}
