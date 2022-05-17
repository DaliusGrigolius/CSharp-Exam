namespace Repository.Models
{
    public abstract class Service_Personnel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int PositionHeld { get; set; }

        public Service_Personnel(int id, string firstName, string lastName, int age, string gender, int positionHeld)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            PositionHeld = positionHeld;
        }
    }
}
