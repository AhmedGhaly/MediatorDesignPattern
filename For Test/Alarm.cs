using System;
using System.Collections.Generic;
using System.Text;

namespace For_Test
{
    public class Alarm
    {
        private readonly IMediator mediator;

        public Alarm(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Ring()
        {
            Console.WriteLine("Alarm is Ringing");
            mediator.Notify(this, "AlarmOn");
        }

        public void Stop()
        {
            Console.WriteLine("Alarm: Stopped.");
        }
    }
}
