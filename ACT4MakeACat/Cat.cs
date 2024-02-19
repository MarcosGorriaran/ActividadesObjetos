

namespace ACT4MakeACat
{
    public class Cat
    {
        public static readonly string[] Breeds = {"breed1","breed2"};
        private const string CatSound = "meow";
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
            get { return this.age; }
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

        public string MakeMeowSound()
        {
            return Cat.CatSound;
        }
        public string Play()
        {
            return $"{this.Name} the cat is having fun playing with you";
        }
        public string Wash()
        {
            return $"{this.Name} the cat dislikes being washed but sacrifaces must be done for his own health";
        }
        public string Eat(string food)
        {
            return food.Equals(this.favFood) ? $"{this.Name} the cat loves the fact that you provided him his favourite food":$"{this.Name} enjoys his meal";
        }
        public string Hunt()
        {
            return $"{this.Name} the cat brings a rat that it hunted, how adorable and probably disgusting";
        }
    }
}
