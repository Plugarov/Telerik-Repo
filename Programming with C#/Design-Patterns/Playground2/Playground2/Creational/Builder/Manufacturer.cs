using System;

namespace Playground2.Builder
{
    class Manufacturer
    {
        public void Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildDispaly();
            phoneBuilder.BuildBattery();

        }
    }
}