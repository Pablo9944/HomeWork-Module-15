
class Program
{
    static void Main()
    {
        var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
        var allStudents = GetAllStudents(classes);
       
        Console.WriteLine(string.Join(" ", allStudents));
    }

    static string[] GetAllStudents(Classroom[] classes)
    {
        var result = from students in classes
                     from student in students.Students
                     select student;
       
        string[] tempArray = new string[result.Count()];
        
        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = tempArray.Take(i).ToString();
        }
        return tempArray;
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
}