using For_Test;

namespace MediatorPattern;

public class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new Mediator();

        var alarm = new Alarm(mediator);
        var door = new door(mediator);
        var coffe = new Coffee(mediator);
        var light = new lights(mediator);

        mediator.lights = light;
        mediator.door = door;
        mediator.Coffee = coffe;
        mediator.Alarm = alarm;

        alarm.Ring();

        door.OpenDoor();
    }
}
