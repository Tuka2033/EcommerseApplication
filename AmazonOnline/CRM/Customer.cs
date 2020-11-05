
using System;

namespace CRM
{
    public class Customer
    {
        public int Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime Registrationdate { get; set; }
        public string Fax { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Customer() { }
        public Customer(int id,string firstName, string lastName,string email,int contactNumber, string fax, DateTime date,string address, string zip,string state)
        {
            this.Id = id;
            this.Firstname = firstName;
            this.Lastname = lastName;
            this.Email = email;
            this.ContactNumber = contactNumber;
            this.Fax = fax;
            this.Registrationdate = date;
            this.Address = address;
            this.Zip = zip;
            this.State = state;
        }
        public override string ToString()
        {
            return this.Id + " " + this.Firstname + " " + this.Lastname + " " +this.Email + " " + this.ContactNumber +this.Fax+" "+this.Registrationdate+""+this.Address+" "+this.Zip+" "+this.State;
        }
    }
}
