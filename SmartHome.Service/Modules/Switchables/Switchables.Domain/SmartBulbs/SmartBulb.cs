using Switchables.Domain.SmartBulbs.ValueObjects;

namespace Switchables.Domain.SmartBulbs
{
    public class SmartBulb
    {
        public Guid Id { get; protected set; }
        public bool OnState { get; protected set; }
        public RgbState RgbState { get; protected set; }

        private SmartBulb(bool onState, RgbState rgbState)
        {
            OnState = onState;
            RgbState = rgbState;
        }

        public static SmartBulb Create(bool onState, RgbState rgbState) 
        { 
            return new SmartBulb(onState, rgbState);
        }

        public void SetOnState(bool onState)
        {
            OnState = onState;
        }

        public void SetRgbState(byte red, byte green, byte blue)
        {
            RgbState.Red = red;
            RgbState.Green = green;
            RgbState.Blue = blue;
        }
    }
}
