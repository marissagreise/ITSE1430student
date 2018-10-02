﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Attributes { get; set; } = 1;
        public int GetAttributes()
        {
            return _attributes;
        }
        public void SetAttributes (int value)
        {
            if (value >= 1 && value <= 100)
                _attributes = value;
        }
        private int _attributes;

        public string Description
        {
            get { return _description ?? " "; }
            set { _description = value; }
        }
        private string _description;
    }
}
