

namespace ACT4MakeACat
{
    public class Cat
    {
        public static readonly string[] Breeds = {"breed1","breed2"};
        private string name;
        private string breed;
        private string favFood;
        private int age;

        public Cat(string name, string breed, string favFood, int age)
        {
            this.Name = name;
            this.Breed = breed;
            this.FavFood = favFood;
            this.Age = age;
        }

        public string Name
        {
           get { return this.name; } set { this.name = value; }
        }
        public string Breed
        {
            get { return this.breed; }
            set
            {
                if (CheckBreedExists(value))
                {
                    this.breed = value;
                }
                else
                {
                    throw new Exception("The specified breed doesn't exists");
                }
            }
        }
        public string FavFood
        {
            get { return this.favFood; }
            set { this.favFood = value; }
        }
        public int Age
        {
            get { return this.Age; }
            set { this.age = value; }
        }

        private static bool CheckBreedExists(string breed)
        {
            for(int i = 0; i < Breeds.Length; i++)
            {
                if (Breeds[i] == breed.ToLower()) return true;
            }
            return false;
        }
    }
}
