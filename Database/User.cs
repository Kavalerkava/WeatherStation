namespace Database
{
    public class User
    {
        private static int counter;

        public int Id { get; set; }
        public string Name { get; set; }

        public User(string name, int id)
        {
            Name = name;
            Id = id;
            counter++;
        }
    }
}