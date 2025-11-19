using System;
using System.Collections.Generic;
using System.Text;

namespace For_Test
{
    public class Coffee
    {
        private readonly IMediator mediator;

        public Coffee(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void MakeCoffe()
        {
            Console.WriteLine("Coffe Maker Start...");
            mediator.Notify(this, "CoffeOn");
        }
        public void Stop()
        {
            Console.WriteLine("coffe Stoped");
        }
    }
}
