using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact 
    {
        public string Name
        {
            get { return _name ?? ""; }  
            set { _name = value; }    
        }

        private string _name = "";

        

    }
    public interface IMessageService
    {
        /// <summary>Sends a message.</summary>
        void Send( string emailAddress, string subject, string message );
    }
}
