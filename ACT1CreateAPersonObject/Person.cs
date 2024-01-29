namespace ACT1CreateAPersonObject
{
    public class Person
    {
        private string name;
        private string surname;
        private string birthDate;
        private float height;
        private readonly string[] dateFormats ={"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                                               "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                                               "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                                               "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                                               "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};
        private readonly string ActualCulture = "en-US";
        public Person(string name, string surname, string birthDate, float height)
        {

        }

        public string GetName() { return this.name; }
        public string GetSurname() { return this.surname; }
        public string GetBirthDate() { return this.birthDate; }
        public float GetHeight() { return this.height; }
        public void SetName(string name) {this.name = name;}
        public void SetSurname(string surname) {this.surname = surname;}
        public void SetDate(string date) 
        {
            DateTime dateValue;
            DateTime.TryParse(date, out dateValue);
            this.birthDate = date;
        }
    }
}
