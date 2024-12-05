namespace _2Modul_Lesson1.Models;

public class Teacher
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Subject { get; set; } // Mavzulari

    public int Likes { get; set; } // O'quvchilarning baholash tarzi zo'r

    public int DisLikes { get; set; } // O'quvchilarning baholash tarzi yaxshiemas

    public string Gender { get; set; } // Jinsi
}
