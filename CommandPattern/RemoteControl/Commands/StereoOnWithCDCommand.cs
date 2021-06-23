using RemoteControl.Commands;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            // technically to turn on you have to set volume right and put cd in to play
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }
    }
}