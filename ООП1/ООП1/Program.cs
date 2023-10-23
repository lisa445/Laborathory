using System;
using System.Collections.Generic;
using System.Text;
namespace lab1 {
    public class student 
    {
        public string name;
        public int mark;
    }
    class Program
    {
        public static void Print(string word1, int mark)
        {
            Console.WriteLine("Имя и фамилия: " + word1);
            Console.WriteLine("Оценка: " + mark);
        }
        public static string name(string name)
        {
            name = Console.ReadLine();
            return name;
        }
        public static int mark(int mark)
        {
            mark = Convert.ToInt32(Console.ReadLine());
            return mark;
        }
        public static void Main(string[] args)
        {
            
            student first = new student();
            student second = new student();
            student three = new student();
            Console.WriteLine("Впишите имя и фамилию трех студентов и их оценки за контрольную работу: ");
            first.name = name(first.name);
            first.mark = mark(first.mark);
            second.name = name(second.name);
            second.mark = mark(second.mark);
            three.name = name(three.name);
            three.mark = mark(three.mark);
            Console.WriteLine("Если хотите проверить журнал, нажмите 'y': ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y') {
                Print(first.name, first.mark);
                Print(second.name, second.mark);
                Print(three.name, three.mark);
            }
        }
    }

}
