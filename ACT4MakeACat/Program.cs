namespace ACT4MakeACat
{
    public class Execute
    {
        public static void Main()
        {
            Cat firstCat = new Cat("Luis","breed1","nothing",2);
            Cat secondCat = new Cat("quacky","breed2","something",4);
            
            Console.WriteLine(firstCat.MakeMeowSound());
            Console.WriteLine(secondCat.MakeMeowSound());
            Console.WriteLine(firstCat.Eat("nothing"));
            Console.WriteLine(secondCat.Eat("nothing"));
        }
    }
}
