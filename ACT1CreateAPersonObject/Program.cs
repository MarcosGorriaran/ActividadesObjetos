using ACT1CreateAPersonObject;

namespace ACT1
{
    public class Execute
    {
        public static void Main()
        {
            Person someone = new Person("Someone","SomeSurname",1.78f);
            Console.WriteLine(someone.GetName()+" "+someone.GetSurname()+" "+someone.GetHeight());
        }
    }
}