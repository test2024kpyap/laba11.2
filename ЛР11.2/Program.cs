using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ЛР11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ResearchTeam team = new ResearchTeam();
                Console.WriteLine(team.ToShortString());
                Console.WriteLine(team[TimeFrame.TwoYears]);
                Console.WriteLine(team[TimeFrame.Year]);
                Console.WriteLine(team[TimeFrame.Long]);
                Console.WriteLine("Введите имя: ");
                team.Name = Console.ReadLine();
                Console.WriteLine("Введите организацию: ");
                team.Organization = Console.ReadLine();
                Console.WriteLine("Введите регистрационный номер: ");
                team.RegistrationNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите TimeFrame: ");
                team.TimeFrame = (TimeFrame)int.Parse(Console.ReadLine());
                team.AddPapers(new Paper[]
                {
                new Paper()
                });
                Console.WriteLine(team);
                Console.WriteLine(team.Publications[0]);
                Console.WriteLine("Введите размеры массива в одну строку, используя пробел, запятую или точку с запятой:");
                string input = Console.ReadLine();
                string[] dimensions = input.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int nrows = int.Parse(dimensions[0]);
                int ncols = int.Parse(dimensions[1]);

                
                Paper[] arr = new Paper[nrows + ncols];
                Paper[,] array = new Paper[nrows, ncols];
                Paper[][] mass = new Paper[nrows][];
                for (int i = 0; i < nrows; i++)
                {
                    mass[i] = new Paper[ncols];
                }

                
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Paper();
                }
                for (int i = 0; i < nrows; i++)
                {
                    for (int j = 0; j < ncols; j++)
                    {
                        array[i, j] = new Paper();
                        mass[i][j] = new Paper();
                    }
                }

                Stopwatch stopwatch = new Stopwatch();

                
                stopwatch.Restart();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i].Name = "Новая бумага";
                }
                stopwatch.Stop();
                Console.WriteLine($"Время выполнения операции для одномерного массива: {stopwatch.Elapsed.TotalMilliseconds} мс");

                
                stopwatch.Restart();
                for (int i = 0; i < nrows; i++)
                {
                    for (int j = 0; j < ncols; j++)
                    {
                        array[i, j].Name = "Новая бумага";
                    }
                }
                stopwatch.Stop();
                Console.WriteLine($"Время выполнения операции для двумерного массива: {stopwatch.Elapsed.TotalMilliseconds} мс");

                
                stopwatch.Restart();
                for (int i = 0; i < nrows; i++)
                {
                    for (int j = 0; j < ncols; j++)
                    {
                        mass[i][j].Name = "Новая бумага";
                    }
                }
                stopwatch.Stop();
                Console.WriteLine($"Время выполнения операции для ступенчатого массива: {stopwatch.Elapsed.TotalMilliseconds} мс");

                
                Console.WriteLine($"Количество строк: {nrows}");
                Console.WriteLine($"Количество столбцов: {ncols}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
