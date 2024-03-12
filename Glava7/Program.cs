using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava7
{
    class StringDemo
    {
        static void Main()
        {
            // Символьный массив:
            char[] symbols = { 'Я', 'з', 'ы', 'к', ' ', 'С', '#' };
            Console.WriteLine("Символьный массив:");
            // Отображение содержимого символьного массива:
            foreach (char symbol in symbols)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            // Текстовый объект создается на основе символьного массива:
            string A = new string(symbols);
            // Проверка значения текстового объекта:
            Console.WriteLine("A:  \"{0}\"", A);
            // Текстовый объект создается на основе нескольких элементов из символьного массива:
            string B = new string(symbols, 1, 5);
            // Проверка значения текстового объекта:
            Console.WriteLine("B:  \"{0}\"", B);
            // Текстовый объект создается как последовательность одинаковых символов:
            string C = new string('ы', 7);
            // Проверка значения текстового объекта:
            Console.WriteLine("C:  \"{0}\"", C);
            // Создание текстового объекта путем вызова статического метода с двумя символьными аргументами:
            A = GetText('А', 'Н');
            // Проверка значения текстового объекта:
            Console.WriteLine("A:  \"{0}\"", A);
            // Создание текстового объекта путем вызова статического метода с двумя символьными аргументами:
            B = GetText('Н', 'А');
            // Проверка значения текстового объекта:
            Console.WriteLine("B:  \"{0}\"", B);
            // Создание текстового объекта путем вызова статического метода с аргументом - символьным массивом:
            C = GetText(symbols);
            // Проверка значения текстового объекта:
            Console.WriteLine("C:  \"{0}\"", C);
        }

        // Статический метод для создания текстового объекта на основе символьного массива:
        static string GetText(char[] symbols)
        {
            // Результат метода:
            return new string(symbols);
        }

        // Статический метод для создания текстового объекта на основе двух символьных значений:
        static string GetText(char a, char b)
        {
            // Локальная текстовая переменная:
            string txt = "";
            // Формирование текстовой строки:
            while (a <= b)
            {
                // Дописывание символа к текстовой строке:
                txt += a;
                // Следующий символ для строки:
                a++;
            }
            // Результат метода:
            return txt;
        }
    }





    class IndexingStringDemo
    {
        static void Main()
        {
            // Отображение текстового литерала с помощью оператора цикла по коллекции:
            foreach (char s in "Текст")
            {
                Console.Write(s + "  ");
            }
            // Переход к новой строке:
            Console.WriteLine();
            // Отображение текстового литерала с помощью оператора цикла:
            for (int k = 0; k < "Текст".Length; k++)
            {
                Console.Write("Текст"[k] + "_");
            }
            // Переход к новой строке:
            Console.WriteLine();
            // Текстовая переменная:
            string A = "Изучаем C#";
            // Отображение текстового значения:
            for (int k = 0; k < A.Length; k++)
            {
                Console.WriteLine(A[k]);
            }
            // Отображение текста в обратном порядке:
            ShowReversed(A);
            // Проверка значения текстового объекта:
            Console.WriteLine(A);
            // Новый текстовый объект (текст в обратном порядке):
            string B = GetReversed(A);
            // Отображение текстового значения:
            Console.WriteLine(B);
        }

        // Статический метод для создания текстового объекта, в котором текст записан в обратном порядке:
        static string GetReversed(string txt)
        {
            // Локальная текстовая переменная:
            string str = "";
            // Формирование текстовой строки:
            foreach (char s in txt)
            {
                // Добавление символа в начало строки:
                str = s + str;
            }
            // Результат метода:
            return str;
        }

        // Статический метод для отображения текста в обратном порядке:
        static void ShowReversed(string txt)
        {
            // Перебор символов в тексте (в обратном порядке):
            for (int k = txt.Length - 1; k >= 0; k--)
            {
                // Отображение в консоли символа:
                Console.Write(txt[k]);
            }
            // Переход к новой строке:
            Console.WriteLine();
        }
    }







    class CompStringDemo
    {
        // Статический метод для сравнения текстовых строк:
        static bool StrCmp(string X, string Y)
        {
            // Если строки разной длины:
            if (X.Length != Y.Length)
                return false;
            // Если строки одинаковой длины:
            for (int k = 0; k < X.Length; k++)
            {
                // Если символы в текстовых строках разные:
                if (X[k] != Y[k])
                    return false;
            }
            // Результат метода, если строки одинаковой длины
            // и все символы в текстовых строках совпадают:
            return true;
        }

        static void Main()
        {
            // Символьный массив:
            char[] smЬ = { 'Я', 'з', 'ы', 'к', ' ', 'С', '#' };
            // Текстовый объект:
            string A = "Язык С#";
            // Отображение текстовой строки:
            Console.WriteLine("A:  \"{0}\"", A);
            // Создание нового текстового объекта:
            string B = new string(smЬ);
            // Отображение текстовой строки:
            Console.WriteLine("B:  \"{0}\"", B);
            // Еще один текстовый объект:
            string C = "ЯЗЫК С#";
            // Отображение текстовой строки:
            Console.WriteLine("C:  \"{0}\"", C);
            Console.WriteLine("Сравнение строк");
            // Сравнение текстовых строк:
            Console.WriteLine("A==B: {0}", A == B);
            Console.WriteLine("StrCmp(A, B): {0}", StrCmp(A, B));
            Console.WriteLine("A==C: {0}", A == C);
            Console.WriteLine("StrCmp(A, C): {0}", StrCmp(A, C));
            Console.WriteLine("B!=C:  {0}", B != C);
            Console.WriteLine("StrCmp(A, \"С#\"): {0}", StrCmp(A, "С#"));
        }
    }







    class SearchStringDemo
    {
        static void Main()
        {
            // Текст, в котором выполняется поиск:
            string txt = "Итак, два плюс два и умножить на два равно шести";
            // Отображение текстового значения:
            Console.WriteLine("Исходный текст:");
            Console.WriteLine("\"{0}\"", txt);
            // Текстовая строка для поиска:
            string str = "два";
            // Отображение текстового значения:
            Console.WriteLine("Строка для поиска:");
            Console.WriteLine("\"{0}\"", str);
            // Переменная для записи значения индекса:
            int index;
            // Индекс первого вхождения строки в текст:
            index = txt.IndexOf(str);
            Console.WriteLine("Первое совпадение:  {0}", index);
            // Индекс второго вхождения строки в текст:
            index = txt.IndexOf(str, index + 1);
            Console.WriteLine("Второе совпадение:  {0}", index);
            // Индекс последнего вхождения строки в текст:
            index = txt.LastIndexOf(str);
            Console.WriteLine("Последнее совпадение:  {0}", index);
            // Индекс для начала поиска и количество символов:
            int a = 7, b = 9;
            Console.WriteLine("Поиск с {0}-го индекса по {1} символам:", a, b);
            // Индекс первого вхождения строки на интервале:
            index = txt.IndexOf(str, a, b);
            Console.WriteLine("Совпадение на индексе:  {0}", index);
            // Изменяем количество символов для поиска:
            b += 3;
            Console.WriteLine("Поиск с {0}-го индекса по {1} символам:", a, b);
            index = txt.IndexOf(str, a, b);
            Console.WriteLine("Совпадение на индексе:  {0}", index);
            // Символ для поиска:
            char sym = 'а';
            Console.WriteLine("Теперь ищем букву '{0}'", sym);
            // Поиск первого совпадения:
            index = txt.IndexOf(sym);
            Console.WriteLine("Первое совпадение:  {0}", index);
            // Поиск второго совпадения:
            index = txt.IndexOf(sym, index + 1);
            Console.WriteLine("Второе совпадение:  {0}", index);
            // Последнее совпадение:
            index = txt.LastIndexOf(sym);
            Console.WriteLine("Последнее совпадение:  {0}", index);
            // Предпоследнее совпадение:
            index = txt.LastIndexOf(sym, index - 1);
            Console.WriteLine("Предпоследнее совпадение:  {0}", index);
        }
    }









    

    class ReplaceStringDemo
    {
        static void Main()
        {
            // Исходный текст:
            string txt = "Мы изучаем С#";
            // Проверка исходного текста:
            Console.WriteLine(txt);
            // Текстовая переменная:
            string str;
            // Вставка слова "язык" в текст:
            str = txt.Insert(3, "язык ");
            // Проверка текста после вставки:
            Console.WriteLine(str);
            // Вставка слова "не" перед "С#" с последующей заменой "С#" на "Java":
            str = str.Insert(3, "не ").Replace("С#", "Java");
            // Проверка текста после вставки и замены:
            Console.WriteLine(str);
            // Замена пробелов на подчеркивания:
            str = str.Replace(' ', '_');
            // Проверка текста после замены пробелов:
            Console.WriteLine(str);
            // Извлечение подстроки с позиции 2 длиной 12 символов:
            str = str.Substring(2, 12);
            // Проверка текста после извлечения подстроки:
            Console.WriteLine(str);
            // Извлечение подстроки начиная с позиции 3 до конца строки:
            str = txt.Substring(3);
            // Проверка текста после извлечения подстроки:
            Console.WriteLine(str);
            // Проверка исходного текста:
            Console.WriteLine(txt);
        }
    }





   

    class SplittingStringDemo
    {
        static void Main()
        {
            // Исходная текстовая строка:
            string txt = "Дорогу осилит идущий";
            // Отображение исходного текста:
            Console.WriteLine(txt);
            // Текстовая строка:
            string str;
            // Текст с символами в верхнем регистре:
            str = txt.ToUpper();
            // Проверка текстового значения:
            Console.WriteLine(str);
            // Текст с символами в нижнем регистре:
            str = txt.ToLower();
            // Проверка текстового значения:
            Console.WriteLine(str);
            // Переменная для текстового массива:
            string[] words;
            // Разбивка текста на подстроки:
            words = txt.Split();
            // Отображение подстрок:
            for (int k = 0; k < words.Length; k++)
            {
                Console.WriteLine((k + 1) + ":  " + words[k]);
                Console.WriteLine();
            }
            // Разбивка текста на подстроки:
            words = txt.Split('у', 'и');
            // Отображение подстрок:
            for (int k = 0; k < words.Length; k++)
            {
                Console.WriteLine((k + 1) + ":  " + words[k]);
                Console.WriteLine();
            }
            // Разбивка текста на подстроки:
            words = txt.Split(new char[] { 'у', 'и' }, 3);
            // Отображение подстрок:
            for (int k = 0; k < words.Length; k++)
            {
                Console.WriteLine((k + 1) + ":  " + words[k]);
            }
            // Переменная для символьного массива:
            char[] symbs;
            // Массив из символов, формирующих текст:
            symbs = txt.ToCharArray();
            // Отображение символов из массива:
            for (int k = 0; k < symbs.Length; k++)
            {
                Console.Write(symbs[k] + " ");
                Console.WriteLine();
            }
        }
    }

}
