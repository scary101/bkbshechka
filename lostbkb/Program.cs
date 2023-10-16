using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace lostbkb
{
    internal class Program
    {
        static int indexdop = 2;
        static int index = 0;
        static List<BigNote> main_note = new List<BigNote>();
        static List<SmallNote> second_note = new List<SmallNote>();
        static List<SmallNote> third_note = new List<SmallNote>();
        static void Main()
        {
            BigNote note1 = new BigNote();
            main_note.Add(note1);
            note1.name = "Заметка 1 Дата  06.10.2023";
            note1.AddNumber("  1. Проснуться");
            note1.AddNumber("  2. Зарегать катку в доту");
            
            BigNote note2 = new BigNote();
            main_note.Add(note2);
            note2.name = "Заметка 2 Дата  07.10.2023";
            note2.AddNumber("  1. Проснуться");
            note2.AddNumber("  2. Понять как все плохо");
            note2.AddNumber("  3. Пойти на пары");
            SmallNote a = new SmallNote();
            a.name = "Проснуться";
            a.deck = "Встать с кровати";
            a.data = new DateTime(2023, 10, 10, 10, 0, 0);
            second_note.Add(a);
            SmallNote b = new SmallNote();
            b.name = "Зарегать катку в доту";
            b.deck = "Включить ПК, открыть доту, слить птс, закрыть доту";
            b.data = new DateTime(2023, 10, 10, 23, 0, 0);
            second_note.Add(b);
            SmallNote c = new SmallNote();
            c.name = "Прснуться";
            c.deck = "Не вставать с кровати";
            c.data = new DateTime(2023, 10, 11, 8, 0, 0);
            third_note.Add(c);
            SmallNote d = new SmallNote();
            d.name = "Понять как все плохо";
            d.deck = "Произошло понимание";
            d.data = new DateTime(2023, 10, 11, 8, 30, 0);
            third_note.Add(d);
            SmallNote f = new SmallNote();
            f.name = "Пойти на пары";
            f.deck = "Крепко спать дома)";
            f.data = new DateTime(2023, 10, 11, 9, 30, 0);
            third_note.Add(f);   
           
            Menu();
            while (true)
            {
                
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        ChangeData();
                        break;
                    case ConsoleKey.RightArrow:
                        ChangeData();
                        break;
                    case ConsoleKey.Enter:
                        dop();
                        Console.Clear();
                        Menu();
                        break;
                    case ConsoleKey.UpArrow:
                        strelka(key);
                        break;
                    case ConsoleKey.DownArrow:
                        strelka(key);
                        break;

                }
            }



        }
        static void Menu()
        {
            Console.WriteLine("Ежедневник");
            main_note[index].PrintNumbers();
        }
        static void strelka(ConsoleKeyInfo key)
        {
            int max = 5;
            if (index == 0)
            {
                max--;
            }
            Console.SetCursorPosition(0, indexdop);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {

                indexdop--;
                if (indexdop <= 1)
                {
                    indexdop = max - 1;
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                indexdop++;
                if (indexdop >= max)
                {
                    indexdop = 2;
                }
            }

            Console.SetCursorPosition(0, indexdop);
            Console.WriteLine("->");
        }
        static void ChangeData()
        {
            if (index > 0)
            {
                index--;
                Console.Clear();
                Menu();

            }
            else if (index < main_note.Count - 1 )
            {
                index++;
                Console.Clear();
                Menu();
            }
        }
        static void dop ()
        {
            if (index == 0)
            {
                SmallNote zametka = second_note[indexdop - 2];
                Console.Clear();
                Console.WriteLine("Заметка: " + zametka.name);
                Console.WriteLine("Описание: " + zametka.deck);
                Console.WriteLine("До когда сделать: " + zametka.data);
                Console.WriteLine("Нажмите любую клавишу чтобы выйти");
                Console.ReadKey();
            }
            else if (index == 1)
            {
                SmallNote zametka = third_note[indexdop - 2];
                Console.Clear();
                Console.WriteLine("Заметка: " + zametka.name);
                Console.WriteLine("Описание: " + zametka.deck);
                Console.WriteLine("До когда сделать: " + zametka.data);
                Console.WriteLine("Нажмите любую клавишу чтобы выйти");
                Console.ReadKey();
            }
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }   
    
    
}
