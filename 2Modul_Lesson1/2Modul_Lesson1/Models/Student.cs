namespace _2Modul_Lesson1.Models;

public class Student
{
    public Guid Id { get; set; } // ID oladi

    public string FirstName { get; set; } // Ism

    public string LastName { get; set; } // Familya

    public int Age { get; set; } // Yoishi

    public string Degree { get; set; } // Darajasi

    public string Gender { get; set; } // Jinsi

    public List<int> Results { get; set; } // 
}
