using System;
using System.Collections.Generic;
using System.Text;

namespace For_Test
{
    public class door
    {
        private readonly IMediator mediator;

        public door(IMediator mediator)
        {
            this.mediator = mediator;
        }


        public void OpenDoor()
        {
            Console.WriteLine("the door open..");
            mediator.Notify(this, "DoorOpen");
        }

        public void CloseDoor() {
            Console.WriteLine("Door Close");
        }
    }
}
