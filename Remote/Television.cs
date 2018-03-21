using System;
namespace Remote
{
    public class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public Television()
        {
        }

        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");

        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV volume is {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV volume is {Volume}");
        }
    }
}
