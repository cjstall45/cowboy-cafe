/*
* Author: Charlie Stallbaumer
* Class name:TrailBurger
* Purposes: to create a class that describes the trailburger
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class that describes the trailburger
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// the price of the Trailburger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// the calories of the Trailburger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }
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
        /// <summary>
        /// list of instruction for preparing the burger
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

                return instructions;
            }
        }
        /// <summary>
        /// a overrideing of the tostring method
        /// </summary>
        /// <returns>the type of the object as a string</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
