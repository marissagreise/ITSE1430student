/* Marissa Greise
 * ITSE 1430
 * 11/01/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public interface IMessageServices
    {
        void Send( string emailAddress, string subject, string message );
    }
}
