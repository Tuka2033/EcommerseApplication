
namespace CRM
{
    public class Customer
    {
        public int Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }

        public Customer() { }
        public Customer(int id,string firstName, string lastName,string email,int contactNumber)
        {
            this.Id = id;
            this.Firstname = firstName;
            this.Lastname = lastName;
            this.Email = email;
            this.ContactNumber = contactNumber;
        }
        public override string ToString()
        {
            return this.Id + " " + this.Firstname + " " + this.Lastname + " " +this.Email + " " + this.ContactNumber;
        }
    }
}
