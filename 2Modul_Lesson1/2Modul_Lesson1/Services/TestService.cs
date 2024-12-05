using _2Modul_Lesson1.Models;

namespace _2Modul_Lesson1.Services;

public class TestService
{
    public List<string> QuestionText(List<string> text)
    {
        List<Test> tests = new List<Test>();

        tests.Add(new Test("O'zbekistonni poytaxti qayer?", "a) Toshkent", "b) Samarqand", "c) Buhoro", "a"));
        return text;
    }

    public static bool AnswerAll(List<Test> tests)
    {
        bool allCorrect = true;

        foreach (var test in tests)
        {
            Console.WriteLine(test.QuestionText);
            Console.WriteLine(test.AVariant);
            Console.WriteLine(test.BVariant);
            Console.WriteLine(test.CVariant);

            Console.Write("Javobni kiriting (a, b yoki c): ");
            string userAnswer = Console.ReadLine();

            if (userAnswer != null)
            {
                userAnswer = userAnswer.ToLower();
            }
            else if (userAnswer != test.Answer)
            {
                Console.WriteLine("Xato javob!");
                allCorrect = false;
            }
            else
            {
                Console.WriteLine("To'g'ri javob!");
            }

            Console.WriteLine(); // Bo'sh satr (yangi savol uchun)
        }

        return allCorrect;
    }

}


