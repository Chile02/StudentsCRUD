using Practice.Models;

namespace Practice;
public class StudentClient
{
    private static readonly List<Models.Students> students = new()
    {
        new Models.Students()
        {
            Id = 1,
            Name = "Chile Blessings",
            Age = "19",
            DOB =  new DateTime(2001, 2, 2),
            Classes =  "A"
        },

        new Models.Students()
        {
            Id = 2,
            Name = "Robert Mwandira",
            Age = "29",
            DOB =  new DateTime(2001, 8, 2),
            Classes =  "A"
        }
    };

    public static Students[] GetStudents(){
        return students.ToArray();
    }
}
