using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initBonus = int.Parse(Console.ReadLine());

            double totalBonus = 0.0;
            double maxBonusPoints = 0.0;
            int studAttendences = 0;
            int attendances = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                //Main logic:

                attendances = int.Parse(Console.ReadLine());

                totalBonus = (1.0 * attendances / countOfLectures) * (5 + initBonus);

                if (totalBonus > maxBonusPoints)
                {
                    maxBonusPoints = totalBonus;
                    studAttendences = attendances;
                }
            }

            //Output:

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonusPoints)}.");
            Console.WriteLine($"The student has attended {studAttendences} lectures.");


        }
    }
}
