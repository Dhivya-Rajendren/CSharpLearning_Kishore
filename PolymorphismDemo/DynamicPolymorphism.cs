using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{

    //Dynamic polymophism
    //Run-time polymorphism
    public class PassingMessage
    {
        public virtual void SendMessage()
        {
            Console.WriteLine("Sending message using the Address");
        }
    }

    public class PassingMessageUsingMobile : PassingMessage
    {

    }

    public class PassingMessageUsingEmail : PassingMessage
    {

        //Method overiddding 
        public override void SendMessage()
        {
            Console.WriteLine("Sending message using the Email");
        }

    }
}
