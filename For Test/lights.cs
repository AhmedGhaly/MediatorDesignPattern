using System;
using System.Collections.Generic;
using System.Text;

namespace For_Test
{
    public class lights
    {

        private readonly IMediator mediator;

        public lights(IMediator mediator)
        {
            this.mediator = mediator;
        }


        public void LightOn()
        {
            Console.WriteLine("the lights on..");
            mediator.Notify(this, "lightsOn");
        }

        public void LightOff()
        {
            Console.WriteLine("LightOff");
        }

    }
}
