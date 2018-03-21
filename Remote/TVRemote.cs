using System;
namespace Remote
{
    public class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }

        public TVRemote()
        {
        }
    }
}
