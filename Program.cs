
using Lab11;
using Lab7_Person_Interface_Abstract;
using System;


////номер4----------------------------------------------------------------------------------------------------------------------------
////a
//DoublyLinkedList<int> list = new DoublyLinkedList<int>();

//while (true)
//{
//    Console.Write("Введите любое число в диапазоне (-1000, 1000): ");
//    string str = Console.ReadLine();

//    if (string.IsNullOrEmpty(str))
//    {
//        break;
//    }

//    int number = int.Parse(str);
//    if (list.Size < 2)
//    {
//        list.AddLast(number);
//    }
//    else
//    {
//        if (Math.Abs(number - list.GetFirst) < Math.Abs(number - list.GetLast))
//        {
//            list.AddFirst(number);
//        }
//        else
//        {
//            list.AddLast(number);
//        }
//    }
//}

//Console.WriteLine($"Размер: {list.Size}");
//Console.WriteLine($"Список: {list.ToString()}");


//b
//DoublyLinkedList<string> list2 = new DoublyLinkedList<string>();

//while (true)
//{
//    Console.Write("Введите строку: ");
//    string str = Console.ReadLine();

//    if (string.IsNullOrEmpty(str))
//    {
//        break;
//    }

//    list2.AddLast(str);

//}

//Console.WriteLine($"\nРазмер: {list2.Size}");
//Console.WriteLine($"Список: {list2.ToString()}");






////номер3---------------------------------------------------------------------------------------------------------------------------
////тест MyPair
//MyPair<int, int> arrForTwo = new MyPair<int, int>(1, 2);
//Console.WriteLine("Первые:");
//Console.WriteLine(arrForTwo[0]); 
//Console.WriteLine(arrForTwo[1]);
//Console.WriteLine("\nПереопределенные:");
//arrForTwo[0] = 3;
//arrForTwo[1] = 4;
//Console.WriteLine(arrForTwo[0]); 
//Console.WriteLine(arrForTwo[1]);

//MyPair<int, string> arrForTwo2 = new MyPair<int, string>(1, "lalala");
//Console.WriteLine("\nПервые:");
//Console.WriteLine(arrForTwo2.FirstObj);
//Console.WriteLine(arrForTwo2.SecondObj);
//Console.WriteLine("\nПереопределенные:");
//arrForTwo2.FirstObj = 3;
//arrForTwo2.SecondObj = "nelalala";
//Console.WriteLine(arrForTwo2.FirstObj);
//Console.WriteLine(arrForTwo2.SecondObj);



////тест MyTriple
//MyTriple<int, int, int> arrForThree = new MyTriple<int, int, int>(1, 2, 3);
//Console.WriteLine("\nПервые:");
//Console.WriteLine($"{arrForThree[0]}, {arrForThree[1]}, {arrForThree[2]}");
//Console.WriteLine("\nПереопределенные:");
//arrForThree.FirstObj = 3785;
//arrForThree.SecondObj = 689;
//arrForThree.ThirdObj = 41;
//Console.WriteLine($"{arrForThree[0]}, {arrForThree[1]}, {arrForThree[2]}");


//MyTriple<int, string, double> arrForThree2 = new MyTriple<int, string, double>(1, "aaaaaaaaaaa", 3.9876);
//Console.WriteLine("\nПервые:");
//Console.WriteLine($"{arrForThree2.FirstObj}, {arrForThree2.SecondObj}, {arrForThree2.ThirdObj}");
//Console.WriteLine("\nПереопределенные:");
//arrForThree2.FirstObj = 3785;
//arrForThree2.SecondObj = "that's ok";
//arrForThree2.ThirdObj = 41.8776;
//Console.WriteLine($"{arrForThree2.FirstObj}, {arrForThree2.SecondObj}, {arrForThree2.ThirdObj}");






//номер2------------------------------------------------------------------------------------------------------------------------
//a
//п.1
Person person1 = new Person("Попов", "Иван", new DateTime(1990, 11, 17), 'm');
Person person2 = new Person("Иванова", "Мария", new DateTime(2000, 1, 18), 'F');
Person person3 = new Person("Сидоров", "Андрей", new DateTime(1980, 7, 24), 'M');
Person person4 = new Person("Солин", "Александр", new DateTime(1985, 5, 21), 'M');
//try
//{
//    if (person1.CompareTo(person2) < 0)
//    {
//        Console.WriteLine($"{person1.Name} < {person2.Name}");
//    }
//    else if (person1.CompareTo(person2) == 0)
//    {
//        Console.WriteLine($"{person1.Name} = {person2.Name}");
//    }
//    else
//    {
//        Console.WriteLine($"{person1.Name} > {person2.Name}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//п.2
Person[] persons = { person1, person2, person3, person4 };
//try
//{
//    Array.Sort(persons);
//    Console.WriteLine("\nОтсортированные по имени:");
//    foreach (Person person in persons)
//    {
//        Console.WriteLine($"{person.Name} {person.Surname}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//п.3
Person GetMaxNamePerson(Person[] persons)
{
    if (persons.Length == 0)
    {
        throw new ArgumentException();
    }

    Person[] help = new Person[persons.Length];
    Array.Copy(persons, help, persons.Length);
    Array.Sort(help);

    return help[help.Length - 1];
}

//try { 
//Person maxPerson = GetMaxNamePerson(persons);
//Console.WriteLine($"\nЧеловек максимум - {maxPerson.Name} {maxPerson.Surname}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//b
T GetMax<T>(T[] arr, IComparer<T> comparer)
{
    T[] help = new T[arr.Length];
    Array.Copy(arr, help, arr.Length);
    Array.Sort<T>(help, comparer);

    return help[help.Length - 1];

}
//try
//{
//    Array.Sort(persons, new AgeComparer());
//    Console.WriteLine("\n\nОтсортированные по возрасту:");
//    foreach (Person person in persons)
//    {
//        Console.WriteLine($"{person.Name} {person.Surname}");
//    }

//    Person maxPerson = GetMax(persons, new AgeComparer());
//    Console.WriteLine($"\nЧеловек максимум по возрасту - {maxPerson.Name} {maxPerson.Surname} {maxPerson.FullAge()}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Array.Sort(persons, new SexComparer());
//    Console.WriteLine("\n\nОтсортированные по полу:");
//    foreach (Person person in persons)
//    {
//        Console.WriteLine($"{person.Name} {person.Surname}");
//    }

//    Person maxPerson = GetMax(persons, new SexComparer());
//    Console.WriteLine($"\nЧеловек максимум по полу - {maxPerson.Name} {maxPerson.Surname} {maxPerson.Sex}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}






//номер1--------------------------------------------------------------------------------------------------------------------------------
//a
void Swap<T>(int index1, int index2, T[] arr)
{
    if (index1 < 0 || index1 >= arr.Length)
    {
        throw new ArgumentOutOfRangeException();
    }

    if (index2 < 0 || index2 >= arr.Length)
    {
        throw new ArgumentOutOfRangeException();
    }

    T helper = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = helper;
}


void PrintArr<T>(T[] arr)
{
    if (arr == null)
    {
        throw new ArgumentNullException();
    }

    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

//try
//{
//    int[] intArr = { 4, 7, 34, 78, 56, 12, 0, 56 };
//    Swap(0, 1, intArr);
//    PrintArr(intArr);

//    Console.WriteLine("\n\n\n");
//    double[] doubleArr = { 7.45, 2.445, 89.6, 45.1, 34.78 };
//    Swap(0, 1, doubleArr);
//    PrintArr(doubleArr);

//    Console.WriteLine("\n\n\n");
//    string[] stringArr = { "sdfsd", "sefrtht", "try5465u", "we54t4t", "ijoergpjii" };
//    Swap(0, 1, stringArr);
//    PrintArr(stringArr);

//    Console.WriteLine("\n\n\n");
//    Person[] personArr = { new Person("Фамилия", "Имя"), new Person("Фамилия2", "Имя2", 'F') };
//    Swap(0, 1, personArr);
//    for (int i = 0; i < personArr.Length; i++)
//    {
//        personArr[i].Print();
//    }
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//b
T[] RemoveAtArr<T>(T[] arr, int indexToRemove)
{
    if (arr == null || indexToRemove < 0 || indexToRemove >= arr.Length)
    {
        throw new ArgumentException("Недопустимые параметры.");
    }

    T[] result = new T[arr.Length - 1];
    Array.Copy(arr, 0, result, 0, indexToRemove);
    Array.Copy(arr, indexToRemove + 1, result, indexToRemove, result.Length - indexToRemove);

    return result;
}

//try
//{
//    int[] arr = { 4, 7, 34, 78, 56, 12, 7, 56 };
//    PrintArr(arr);
//    int[] new_arr = RemoveAtArr(arr, 0);
//    PrintArr(new_arr);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}




