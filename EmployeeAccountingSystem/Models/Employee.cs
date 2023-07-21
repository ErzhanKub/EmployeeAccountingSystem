namespace EmployeeAccountingSystem
{
    public class Employee
    {
        private int _age;
        private string _name;
        private string _position;
        public int ID { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value), "Имя не можеть быть пустым.");
                _name = value;
            }
            
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 1 || value > 130)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Не корректные данные ");
                }
                _age = value;
            }
        }
        public string Position
        {
            get => _position;
            set
            {
                _position = value ?? throw new ArgumentNullException(nameof(value), "Должность не может быть пустым");
            }
        }
    }

}
