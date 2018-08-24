namespace Playground2.Builder
{

    internal class AndroidPhoneBuilder : IPhoneBuilder
    {
        MobilePhone phone;

        public AndroidPhoneBuilder()
        {
            this.phone = new MobilePhone("Android phone");
        }

        public void BuildDispaly()
        {
            this.phone.Display = Display.Colorfull;
        }

        public void BuildBattery()
        {
            this.phone.Battery = Battery.LiIon;
        }

        public MobilePhone Phone
        {
            get
            {
                return this.phone;
            }
        }
    }
}