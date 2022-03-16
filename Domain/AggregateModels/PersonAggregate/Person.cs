namespace Domain
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int age { get; set; }
        public string photo { get; set; }

        public Person(int id, string name, string description, int age, string photo)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.age = age;
            this.photo = photo;
        }
    }
}