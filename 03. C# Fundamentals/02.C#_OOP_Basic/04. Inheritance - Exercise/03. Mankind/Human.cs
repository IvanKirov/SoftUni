using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName; 
            set
            {
                NameCheck(value, nameof(firstName));
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName; 
            set
            {
                NameCheck(value, nameof(lastName));                
                lastName = value;
            }
        }

        private void NameCheck(string value, string propertyName)
        {
            if (!char.IsUpper(value[0]))//(value[0] < 65 || value[0] > 90)
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {propertyName}");
            }

            var nameLenght = 3;
            if (propertyName == "firstName")
            {
                nameLenght = 4;
            }
            if (value.Length < nameLenght)
            {
                throw new ArgumentException($"Expected length at least {nameLenght} symbols! Argument: {propertyName}");
            }
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}{Environment.NewLine}" +
                   $"Last Name: {this.LastName}{Environment.NewLine}";
        }
    }
}
