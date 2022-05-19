namespace Repository.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int PinCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PositionHeld { get; set; }

        public Employee(int id, int pinCode, string firstName, string lastName, int age, string gender, string positionHeld)
        {
            Id = id;
            PinCode = pinCode;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            PositionHeld = positionHeld;
        }
    }
}
