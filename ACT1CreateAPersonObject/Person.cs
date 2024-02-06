namespace ACT1CreateAPersonObject
{
    public class Person
    {
        private string name;
        private string surname;
        private float height;
        public Person(string name, string surname, float height)
        {
            SetName(name);
            SetHeight(height);
            SetSurname(surname);
        }

        public string GetName() { return this.name; }
        public string GetSurname() { return this.surname; }
        public float GetHeight() { return this.height; }
        public void SetName(string name) {this.name = name;}
        public void SetSurname(string surname) {this.surname = surname;}
        public void SetHeight(float height) {this.height = height;}
        public override string ToString()
        {
            return this.name+" "+this.surname+"\n"+this.height;
        }
    }
}
