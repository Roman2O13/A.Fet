using System;
namespace PoemApplication
{
    class Poem
    {
        static void Main(string[] args)

        {
            Console.Write("Я пришёл к тебе с приветом...\n");

            Console.Write("\n");

            Console.Write("Я пришёл к тебе с приветом,\n");
            Console.Write("Рассказать, что солнце встало,\n");
            Console.Write("Что оно горячим светом\n");
            Console.Write("По листам затрепетало.\n");

            Console.Write("\n");

            Console.WriteLine("Рассказать, что лес проснулся,");
            Console.WriteLine("Весь проснулся, веткой каждой,");
            Console.WriteLine("Каждой птицей встрепенулся");
            Console.WriteLine("И весенней полон жаждой;");

            Console.Write("\n");

            string stringVar = "Рассказать, что с той же страстью,\nКак вчера, пришёл я снова,\nЧто душа всё так же счастью\nИ тебе служить готова;\n";
            Console.WriteLine(stringVar);

            string say = "Рассказать";
            Console.WriteLine($"{say}, что отовсюду");

            string me = "меня";
            Console.WriteLine($"На {me} весельем веет,");

            string know = "знаю";
            Console.WriteLine($"Что не {know} сам, что буду");

            string sing = "Петь";
            Console.WriteLine($"{sing}, - но только песня зреет.");


            /*
            Рассказать, что отовсюду
            а меня весельем веет,
            Что не знаю сам, что буду
            Петь - но только песня зреет.
            */

            // 1843 г.
            // А. Фет
            Console.ReadLine();
        }
    }
}