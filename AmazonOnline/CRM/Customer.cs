
using System;

namespace CRM
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime Registrationdate { get; set; }
        public string Fax { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Customer() { }
        public Customer(int id,string firstName, string lastName,string email,string contactNumber, string fax, DateTime date,string address, string zip,string state,string username,string password)
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
            this.UserName = username;
            this.Password = password;
        }
        public override string ToString()
        {
            return this.Id + " " + this.Firstname + " " + this.Lastname + " " +this.Email + " " + this.ContactNumber +this.Fax+" "+this.Registrationdate+""+this.Address+" "+this.Zip+" "+this.State;
        }
    }
}
