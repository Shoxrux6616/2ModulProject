namespace _2Modul_Lesson1.Models;

public class Test
{
    public Guid Id { get; set; }

    public string QuestionText { get; set; } // Test savollari

    public string AVariant { get; set; } 

    public string BVariant { get; set; }

    public string CVariant { get; set; }

    public string Answer { get; set; } // Javoblar

    public Test(string questionText, string A, string B, string C, string answer)
    {
        QuestionText = questionText;
        AVariant = A;
        BVariant = B;
        CVariant = C;
        Answer = answer;
    }
}
