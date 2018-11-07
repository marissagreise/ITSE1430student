using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Memory
{
   public class MemoryMessageDatabase : MessageSendDatabase
    {
        protected override SendCore( Message message )
        {
            _items.Add(message);
        }

        protected override IEnumerable<Message> GetAllCore()
        {
            return from item in _items
                   select new Message()
                   {
                       Name = item.Name,
                       EmailAddress = item.EmailAddress,
                       Subject = item.Subject,
                       ComposeMessage = item.ComposeMessage,
                   };
        }

        private List<Message> _items = new List<Message>();
    }
}
