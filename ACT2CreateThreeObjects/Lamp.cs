namespace ACT2CreateThreeObjects
{
    public class Lamp
    {
        private int lightStrength;
        private bool turnedOn;

        public Lamp()
        {

        }

        public int LightStrength
        {
            get { return this.lightStrength; }
            set { this.lightStrength = value; }
        }
        public bool TurnedOn
        {
            get { return this.turnedOn;}
        }
        public void SwitchLampStatus()
        {
            this.turnedOn = this.turnedOn ? false : true;
        }
    }
}
