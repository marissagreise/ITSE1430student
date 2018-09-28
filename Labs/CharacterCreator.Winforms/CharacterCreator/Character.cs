using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public string GetName()
        {
            return _name ?? " ";
        }
        public void SetName (string value)
        {
            _name = value;
        }
        private string _name;

        public string GetProfession()
        {
            return _profession ?? " ";
        }
        public void SetProfession(string value)
        {
            _profession = value;
        }
        private string _profession;

        public string GetRace()
        {
            return _race ?? " ";
        }
        public void SetRace( string value )
        {
            _race = value;
        }
        private string _race;

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

        public string GetDescription()
        {
            return _description ?? " ";
        }
        public void SetDescription (string value )
        {
            _description = value;
        }
        private string _description;
    }
}
