using System;

namespace RemoteControl.Receivers
{
    // object performing the action
    public class Light
    {
        private readonly string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void On() => Console.WriteLine(_location + " light is on");

        public void Off() => Console.WriteLine(_location + " light is off");
    }
}