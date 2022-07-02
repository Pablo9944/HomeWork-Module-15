
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
                     select new
                     {
                         name = student
                     };
       
        string[] tempArray = new string[result.Count()];
        var listTemp = new List<string>();

        foreach (var item in result)
            listTemp.Add(item.name);

        tempArray = listTemp.ToArray();
        
        return tempArray;
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
