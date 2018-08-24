namespace Playground2.Builder
{
    public class MobilePhone
    {
        private string name;
        private Display display;
        private Battery battery;

        public MobilePhone(string name)
        {
            this.Name = name;
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
