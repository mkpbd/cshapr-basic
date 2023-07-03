using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Evn
{
    public class Eventful
    {
        public event Action<string>? Announcement;
        public void Announce(string message)
        {
            Announcement?.Invoke(message);
        }
        // private Action<string>? Announcements = null;
        // Not the actual code.
        // The real code is more complex, to tolerate concurrent calls.
        //public void add_Announcement(Action<string> handler)
        //{
        //     //  Announcement += handler;
        // }
        //  public void remove_Announcement(Action<string> handler)
        // {
        // Announcement -= handler;
        //  }





    }
}