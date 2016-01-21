using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public enum GenderType { Male, Female };
    public class Panda
    {
        private string email;
        public string Name { get; set; }
        public string Email
        {
            get { return email; }
            set 
            {
                if (value.Contains("@")&&value.Substring(value.IndexOf('@')).Contains("."))
                {
                    email = value;
                }            
            }
        }
        public GenderType Gender { get; set; }
        public bool IsMale { get; set; }
        public bool IsFemale { get; set; }
        public Panda(string name, string email, GenderType g)
        {
            Name = name;
            this.Email = email;
            Gender = g;
            if (g == GenderType.Male)
            {
                IsMale = true;
                IsFemale = false;
            }
            else
            {
                IsMale = false;
                IsFemale = true;
            }
        }
    }
}
