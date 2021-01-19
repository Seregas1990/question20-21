using System;
using System.Collections.Generic;
using System.Text;

namespace question20_21
{
    public delegate void EventHandler(string a);

    public class Operation
    {
        public event EventHandler xyz;

        public void Action(string a)
        {
            if (xyz != null)
            {
                xyz(a);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Not Registered");
            }
        }
    }

    public class HandleOperation 
    {
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public void Handle(Operation o)
        {
            o.Action("Event Calling");
            o.xyz += new EventHandler(CatchEvent);
        }
    }
}
