using _2Modul_Lesson1.Models;

namespace _2Modul_Lesson1;

internal class Program
{
    static void Main(string[] args)
    {
        //string fileFath = "../../Student.json";
        //if (File.Exists(fileFath) is false)
        //{
        //    File.Create(fileFath).Close();
        //}
        //if (File.Exists(fileFath) is false)
        //{
        //    File.WriteAllText(fileFath, "[]");
        //}


        List<Test> tests = QuestionText();

        // Savollarga javob berish va tekshirish
        bool allAnswersCorrect = AnswerAll(tests);

        if (allAnswersCorrect)
        {
            Console.WriteLine("Siz barcha savollarga to'g'ri javob berdingiz!");
        }
        else
        {
            Console.WriteLine("Barcha savollarga to'g'ri javob bermadingiz.");
        }
    }

}

