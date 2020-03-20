/*
* Author: Charlie Stallbaumer
* Class name:TexasTripleBurger
* Purposes: to create a class for the texas triple burger entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the texas triple burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        private bool bun = true;
        /// <summary>
        /// if buns are on the burger
        /// </summary>
        public bool Bun 
        { 
            get { return bun; } 
            set 
            {
                bun = value;
                NotifyOfPropertyChanged("Bun");
            } 
        }
        private bool ketchup = true;
        /// <summary>
        /// if ketchup is on the burger
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyOfPropertyChanged("Ketchup");
            }
        }
        private bool mustard = true;
        /// <summary>
        /// if mustard is on the burger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                NotifyOfPropertyChanged("Mustard");
            }
        }
        private bool pickle = true;
        /// <summary>
        /// if pickle is on the burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChanged("Pickle");
            }
        }
        private bool cheese = true;
        /// <summary>
        /// if cheese is on the burger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                NotifyOfPropertyChanged("Cheese");
            }
        }
        private bool tomato = true;
        /// <summary>
        /// if tomato is on the burger
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyOfPropertyChanged("Tomato");
            }
        }
        private bool lettuce = true;
        /// <summary>
        /// if lettuce is on the burger
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                NotifyOfPropertyChanged("Lettuce");
            }
        }
        private bool mayo = true;
        /// <summary>
        /// if mayo is on the burger
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                NotifyOfPropertyChanged("Mayo");
            }
        }
        private bool bacon = true;
        /// <summary>
        /// if bacon is on the burger
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                NotifyOfPropertyChanged("Bacon");
            }
        }
        private bool egg = true;
        /// <summary>
        /// if egg is on the burger
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                NotifyOfPropertyChanged("Egg");
            }
        }
        /// <summary>
        /// price of the texas triple
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }
        /// <summary>
        /// calories of the texas triple
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }
        /// <summary>
        /// instructions for how to make the Texas Triple
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;
            }
        }
        /// <summary>
        /// a overrideing of the tostring method
        /// </summary>
        /// <returns>the type of the object as a string</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
