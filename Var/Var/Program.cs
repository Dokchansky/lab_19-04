using System.Runtime.ConstrainedExecution;
// Вариант 3
dynamic Discip = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите название дисциплины: ");
Discip.Discp = Console.ReadLine() ?? "Дисциплина не указана!";
Console.WriteLine("Введите сокращение дисциплины: ");
Discip.Abrv = Console.ReadLine() ?? "Сокращение не указано!";


// Вариант 6
dynamic Spec = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите специальность: ");
Spec.spec = Console.ReadLine() ?? "Специальность не укзаана!";
Console.WriteLine("Введите сокращение специальности: ");
Spec.abrvSpec = Console.ReadLine() ?? "Сокращение не указано!";


// Вариант 4
dynamic Group = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите название группы: ");
Group.Grop = Console.ReadLine() ?? "Группа не указана";
Console.WriteLine("Введите сокращение группы: ");
Group.AbrvG = Console.ReadLine() ?? "Сокращение не указано!";
Console.WriteLine("Введите численность группы: ");
Group.Members = Console.ReadLine() ?? "Численность не указана!";
Console.WriteLine("Введите год поступления: ");
Group.Date = Console.ReadLine() ?? "Год не указан!";
Group.Spec = Spec.spec;
Console.WriteLine("Введите ФИО классного руководителя: ");
Group.Teacher = Console.ReadLine() ?? "ФИО не указано!";
Group.Teacher = Teacher.Teach;

// Вариант 5
dynamic Student = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите фамилию: ");
Student.Fam = Console.ReadLine() ?? "Фамилия не указана!";
Console.WriteLine("Введите имя: ");
Student.Name = Console.ReadLine() ?? "Имя не указана!";
Console.WriteLine("Введите отчество: ");
Student.Otches = Console.ReadLine() ?? "Отчество не указано!";
Student.Group = Group.grop;
Console.WriteLine("Введите дату рождения: ");
Student.Birth = Console.ReadLine() ?? "Дата рождения не указана!";