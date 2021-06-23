using RemoteControlWithUndo.Receivers;

namespace RemoteControlWithUndo.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        private int _level;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _level = _light.GetLevel();
            _light.On();
        }

        //our undo we just bringing the old light level configuration, we can make it just to turn it back off if we just turned it on
        public void Undo() => _light.Dim(_level);
    }
}