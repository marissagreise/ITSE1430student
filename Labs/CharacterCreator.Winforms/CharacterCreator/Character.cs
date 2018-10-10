﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace CharacterCreator
{
    public class Character
    {
        public string Name
        {
            get { return _name ?? " "; }
            set { _name = value; }
        }
        private string _name = "";

        public string Profession
        {
            get { return _profession ?? " "; }
            set { _profession = value; }
        }
        private string _profession;

        public string Race
        {
            get { return _race ?? " "; }
            set { _race = value; }
        }
        private string _race;

        //[Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }   

        public string Description
        {
            get { return _description ?? " "; }
            set { _description = value; }
        }
        private string _description;
    }
}
