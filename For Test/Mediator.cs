using System;
using System.Collections.Generic;
using System.Text;

namespace For_Test
{
    public class Mediator : IMediator
    {
        public Alarm Alarm { get; set; }
        public Coffee Coffee { get; set; }
        public door door { get; set; }
        public lights lights{ get; set; }

        public void Notify(object sender, string message)
        {


            switch(message)
            {

                case "AlarmOn":
                    Coffee.MakeCoffe();
                    lights.LightOn();
                    break;
                case "DoorOpen":
                    lights.LightOff();
                    Alarm.Stop();
                    break;
            }
        }
    }
}
