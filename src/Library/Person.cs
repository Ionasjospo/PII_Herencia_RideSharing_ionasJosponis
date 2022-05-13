namespace Library
{
    public abstract class Person
    {
        protected string name;
        protected string lastName;
        protected int id;
        protected int rating;

        protected Person(string name, string lastName, int id, int rating)
        {
            this.name = name; 
            this.lastName = lastName;
            this.id = id;
            this.rating = rating;
        }

        public string Name
        {
            get { return this.name; } 
        }
    }
}