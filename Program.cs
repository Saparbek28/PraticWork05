using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                    throw new PersonException("Лицам до 18 регистрация запрещена", value);
                else
                    age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Person p = new Person { Name = "Tom", Age = 13 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
            Console.Read();
        }
    }
}
