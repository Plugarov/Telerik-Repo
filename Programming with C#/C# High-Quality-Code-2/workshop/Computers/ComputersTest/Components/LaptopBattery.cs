namespace ComputersTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Computers.Components.HardDrives;

    [TestClass]
    public class LaptopBatteryChargeTest
    {
        [TestMethod]
        public void Should_ChargeTo50AtFirstInitialisation()
        {
            // Arrange
            LaptopBattery battery = new LaptopBattery();
            int initialCharge = 50;

            // Act && Assert
            Assert.AreEqual(initialCharge, battery.Percentage);
        }

        [TestMethod]
        public void Should_ChargeBatteryWithSpecifiedPowerCharge()
        {
            // Arrange
            LaptopBattery battery = new LaptopBattery();
            int initialCharge = battery.Percentage;
            int newChargeAmount = 10;

            // Act
            battery.Charge(newChargeAmount);

            // Assert
            Assert.AreEqual(initialCharge + newChargeAmount, battery.Percentage);
        }

        [TestMethod]
        public void Should_DischargeBatteryWithSpecifiedPowerCharge()
        {
            // Arrange
            LaptopBattery battery = new LaptopBattery();
            int initialCharge = battery.Percentage;
            int newChargeAmount = -10;

            // Act
            battery.Charge(newChargeAmount);

            // Assert
            Assert.AreEqual(initialCharge + newChargeAmount, battery.Percentage);
        }

        [TestMethod]
        public void Should_NotChargeMoreThan100()
        {
            // Arrange
            LaptopBattery battery = new LaptopBattery();
            int initialCharge = battery.Percentage;
            int newChargeAmount = 150;
            int maximumCharge = 100;

            // Act
            battery.Charge(newChargeAmount);

            // Assert
            Assert.AreEqual(maximumCharge, battery.Percentage);
        }

        [TestMethod]
        public void Should_NotDischargeLessThanZero()
        {
            // Arrange
            LaptopBattery battery = new LaptopBattery();
            int initialCharge = battery.Percentage;
            int newChargeAmount = -150;
            int minimumCharge = 0;

            // Act
            battery.Charge(newChargeAmount);

            // Assert
            Assert.AreEqual(minimumCharge, battery.Percentage);
        }
    }
}
