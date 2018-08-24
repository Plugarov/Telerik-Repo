namespace Playground2.Builder
{
    internal interface IPhoneBuilder
    {
        void BuildDispaly();

        void BuildBattery();

        MobilePhone Phone { get; }
    }
}