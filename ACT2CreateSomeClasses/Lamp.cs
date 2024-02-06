namespace ACT2CreateSomeClasses
{
    public class Lamp
    {
        private const bool DefaultLightSwitchStatus=false;
        private float lightStrength;
        private float height;
        private float width;
        private bool lightSwitch;

        public Lamp(float lightStrength, float height, float width, bool lightSwitchStatus)
        {
            LightStrength = lightStrength;
            Height = height;
            Width = width;
            LightSwitch = lightSwitchStatus;
        }
        public Lamp(float lightSrength, float height, float width) : this(lightSrength, height, width, DefaultLightSwitchStatus)
        {

        }
        public float LightStrength
        {
            get { return lightStrength; }
            set { lightStrength = value; }
        }
        public float Height
        {
            get => height;
            set { height = value; }
        }
        public float Width
        {
            get => width;
            set { width = value; }
        }
        public bool LightSwitch
        {
            get => lightSwitch;
            set => lightSwitch = value;
        }
        public void presslightSwitch()
        {
            LightSwitch = LightSwitch ? false : true;
        }
    }
}
