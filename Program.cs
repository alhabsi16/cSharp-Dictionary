namespace C_Sharp_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1102, "Osama", "Male");
            Person person2 = new Person(1155, "Salim", "Male");
            Person person3 = new Person(1225, "Alanood", "Female");

            Dictionary<long, Person> personMap = new Dictionary<long, Person>();
            //personMap.Add(person1.Id, person1);
            //personMap.Add(person2.Id, person2);
            //personMap.Add(person3.Id, person3);
            
            personMap[person1.Id] = person1;
            personMap[person2.Id] = person2;
            personMap[person3.Id] = person3;

            person1.Gander = "Female";
            personMap[person1.Id] = person2;
            //personMap.TryAdd(person1.Id, person1);
            Person? result = null;
           
            if(personMap.TryGetValue(1155, out result))
            {
                Console.WriteLine(result);
            }

        }
    }
}