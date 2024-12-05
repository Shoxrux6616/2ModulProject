using _2Modul_Lesson1.Models;
using System.Text.Json;

namespace _2Modul_Lesson1.Services;

public class TeacherService
{

    private string teacherFilePath;

    public TeacherService()
    {
        teacherFilePath = "../../../Data/Students.json";

        if (File.Exists(teacherFilePath) is false)
        {
            File.WriteAllText(teacherFilePath, "[]");
        }
    }

    public Teacher AddTeacher(Teacher teacher) 
    {
        teacher.Id = Guid.NewGuid();
        var teachers = GetTeachers();
        teachers.Add(teacher);
        SaveData(teachers);
        return teacher;
    }

    public Teacher GetById(Guid teacherId)
    {
        var teachers = GetTeachers();
        foreach (var teacher in teachers)
        {
            if (teacher.Id == teacherId)
            {
                return teacher;
            }
        }

        return null;
    }

    public bool DeleteTeacher(Guid teacherId)
    {
        var teachers = GetTeachers();
        var teacherFormat = GetById(teacherId);
        if (teacherFormat is null)
        {
            return false;
        }
        SaveData(teachers);
        return true;
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        var teachers = GetTeachers();
        var techerFarmat = GetById(teacher.Id);
        if (techerFarmat is null)
        {
            return false;
        }

        var index = teachers.IndexOf(teacher);  
        teachers[index] = teacher;
        SaveData(teachers);
        return true;
    }

    public List<Teacher> GetAll()
    {
        return GetTeachers();
    }

    private void SaveData(List<Teacher> teachers)
    {
        var studentsJson = JsonSerializer.Serialize(teachers);
        File.WriteAllText(teacherFilePath, studentsJson);
    }

    private List<Teacher> GetTeachers()
    {
        var teacherJson = File.ReadAllText(teacherFilePath);
        var teachers = JsonSerializer.Deserialize<List<Teacher>>(teacherJson);
        return teachers;
    }

}
