using System;
using System.Collections.Generic;

namespace Library
{
    public class UcuRideShare
    {
        public List <Person> users = new List<Person> ();

        public void AddUser(Person user)
        {
            if (users.Contains(user))
            {
                Console.WriteLine("Users has already added in the list");
            }
            this.users.Add(user);
        }

        public void RemoveUser(Person user)
        {
            if (users.Contains(user))
            {
                this.users.Remove(user);
            }           
        }
    }
}