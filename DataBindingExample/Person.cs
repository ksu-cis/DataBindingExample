using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DataBindingExample
{
    /// <summary>
    /// A class representing a person 
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        /// <summary>
        /// An event triggered when a property changes 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private string firstName = "";
        /// <summary>
        /// This person's first name 
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FullName"));
            }
        }

        private string lastName = "";
        /// <summary>
        /// This person's last name 
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FullName"));
            }
        }

        /// <summary>
        /// This persons' full name 
        /// </summary>
        public string FullName
        {
            get { return $"{firstName} {lastName}"; }
        }

        public bool isCartoon = false;
        /// <summary>
        /// If this person is a cartoon character
        /// </summary>
        public bool IsCartoon
        {
            get { return isCartoon; }
            set
            {
                isCartoon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsCartoon"));
            }
        }

        private Fruit favoriteFruit;
        public Fruit FavoriteFruit
        {
            get { return favoriteFruit; }
            set
            {
                favoriteFruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FavoriteFruit"));
            }
        }

        /// <summary>
        /// Constructs a new person 
        /// </summary>
        /// <param Name="first">The person's first name</param>
        /// <param Name="last">The person's last name</param>
        /// <param Name="isCartoon">If the person is a cartoon character (default false)</param>
        public Person(string first, string last, bool isCartoon = false)
        {
            this.firstName = first;
            this.lastName = last;
            this.isCartoon = isCartoon;
        }
    }

}
