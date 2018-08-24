using Playground2.Builder;

namespace Playground2
{
    internal class WindowsPhoneBuilder : IPhoneBuilder
    {
        public object Phone => throw new System.NotImplementedException();

        MobilePhone IPhoneBuilder.Phone => throw new System.NotImplementedException();

        public void BuildBattery()
        {
            throw new System.NotImplementedException();
        }

        public void BuildDispaly()
        {
            throw new System.NotImplementedException();
        }
    }
}