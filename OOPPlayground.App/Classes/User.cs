using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OOPPlayground.App.Classes
{
    public class User
    {
        private string _firstName;
        
        protected string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        protected string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get { return LastName + " " + FirstName; } }

        public User(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetUserSerialized()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
