using ACT1CreateAPersonObject;

namespace ACT1
{
    public class Execute
    {
        public static void Main()
        {
            Person someone = new Person("Someone","SomeSurname",1.78f);
            Person someone2 = someone;
            Person someone3 = new Person("Someone", "SomeSurname", 1.78f);
            Console.WriteLine(someone.GetHashCode());
            Console.WriteLine(someone2.GetHashCode());
            Console.WriteLine(someone3.GetHashCode());
            someone2.SetName("SomeoneElse");
            Console.WriteLine(someone.GetName());
            Console.WriteLine(someone2.GetName());
        }
    }
}