using EmployeeAccountingSystem.Controllers;
using EmployeeAccountingSystem.Helpers;

namespace EmployeeAccountingSystem.Views
{
    public class ConsoleView
    {
        readonly EmployeeManagement employeeManagement = new();
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Выберите опцию:");
                Console.WriteLine("1. Добавить нового сотрудника.");
                Console.WriteLine("2. Удалить сотрудника.");
                Console.WriteLine("3. Вывести список всех сотрудников.");
                Console.WriteLine("4. Выйти из программы.");

                var option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1": AddEmployee(); break;

                    case "2": RemoveEmployee(); break;

                    case "3": GetAllEmployees(); break;

                    case "4": return;

                    default:
                        Console.WriteLine("Неверная опция.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void AddEmployee()
        {
            Console.WriteLine("Введите эти данные: Имя - Возраст - Должность.");
            var name = Helper.ReadString("Имя: ");
            var age = Helper.ReadInt("Возраст: ");
            var position = Helper.ReadString("Должность: ");

            var employee = new Employee
            {
                ID = employeeManagement.GetAllEmployees().Count + 1,
                Name = name,
                Age = age,
                Position = position
            };

            employeeManagement.AddEmployee(employee);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Сотрудник {name} успешно добавлен.");
            Console.ResetColor();
        }
        private void RemoveEmployee()
        {
            int id = Helper.ReadInt("Введите ID сотрудника: ");
            if (employeeManagement.GetAllEmployees().Any(e => e.ID == id))
            {
                employeeManagement.RemoveEmployee(id);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Сотрудник с ID {id} успешно удален.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Сотрудник с ID {id} не найден.");
                Console.ResetColor();
            }
        }
        private void GetAllEmployees()
        {
            var employees = employeeManagement.GetAllEmployees();

            if(employees.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }

            foreach (var e in employees)
            {
                Console.WriteLine($"ID: {e.ID} | Имя: {e.Name} | Возраст: {e.Age} | Должность: {e.Position}.");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Данные успешно выведены.");
            Console.ResetColor();
        }
    }
}
