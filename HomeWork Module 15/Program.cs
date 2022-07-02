

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
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
            // Создаем Коллекцию типа List,потому что,мы не знаем какая длина нам необходима
            var tempList = new List<string>();

            // Получаем колличество списков
            for (int i = 0; i < classes.Length; i++)
            {
                //Получаем колличество элементов в писке
                for (int j = 0; j < classes[i].Students.Count; j++)
                {
                    // Добавляем полученные элементы из списков в единый список
                    tempList.Add(classes[i].Students[j]);
                }
            }
            //Создаем массив длиною равному единому списку
            var tempArray = new string[tempList.Count];
            
            // Конвертируем единый список в массив
            tempArray = tempList.ToArray();
            
            // Вовзращаем заполненный массив
            return tempArray;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();

        }
    }
}