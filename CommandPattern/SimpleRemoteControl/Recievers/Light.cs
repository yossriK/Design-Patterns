using System;

namespace SimpleRemoteControl.Receivers
{
    // object performing the action
    public class Light
    {
        public void On() => Console.WriteLine("Light is on");

        public void Off() => Console.WriteLine("Light is off");
    }
}