namespace Repository.Models
{
    public class Waitress : Service_Personnel
    {
        public Waitress(int id, string firstName, string lastName, int age, string gender, int positionHeld) : base(id, firstName, lastName, age, gender, positionHeld)
        {

        }
    }
}
