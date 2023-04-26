using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Person_Interface_Abstract
{
    class Person : IComparable<Person>
    {
        private char _sex;


        public string? Surname { get; set; }
        public string? Name { get; set; }
        public DateTime BthDate { get; set; }
        public char Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                if (value == 'F' | value == 'f' | value == 'M' | value == 'm')
                {
                    _sex = value;
                }
            }
        }


        public Person() { }
        public Person(string surname, DateTime bthDate)
        {
            Surname = surname;
            BthDate = bthDate;
        }
        public Person(string surname, string name, DateTime bthDate) : this(surname, bthDate)
        {
            Name = name;
        }
        public Person(string surname, string name, DateTime bthDate, char sex) : this(surname, name, bthDate)
        {
            _sex = sex;
        }
        public Person(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }
        public Person(string surname, string name, char sex) : this(surname, name)
        {
            _sex = sex;
        }
        public Person(Person person)
        {
            Surname = person.Surname;
            Name = person.Name;
            BthDate = person.BthDate;
            _sex = person._sex;
        }


        public virtual void Input()
        {
            Console.WriteLine("Введите фамилию: ");
            Surname = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения в формате дд.мм.гггг: ");
            BthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите пол: ");
            this.Sex = Convert.ToChar(Console.ReadLine());
        }

        public virtual void Print()
        {
            Console.WriteLine($"\nИнформация о человеке: \nФамилия: {Surname} \nИмя: {Name} \nДата рождения: {BthDate} \nПол: {_sex}");
        }


        public override string ToString()
        {
            string c = "";
            if (char.ToUpper(_sex) == 'F')
            {
                c = "женский";
            }
            else if (char.ToUpper(_sex) == 'M')
            {
                c = "мужской";
            }
            return $"\nИнформация о человеке: \nФамилия: {Surname} {char.ToUpper(Name[0])}. \nВозраст: {FullAge()}\nПол: {c}";
        }


        public int FullAge()
        {
            DateTime HelpTime = new DateTime(1, 1, 1);
            TimeSpan span = DateTime.Now - BthDate;
            int age = (HelpTime + span).Year - 1;
            return age;
        }

        public int CompareTo(Person? other)
        {
            if(other == null)
            {
                throw new ArgumentNullException();
            }
            return string.Compare(Name, other.Name);
        }
    }
}
