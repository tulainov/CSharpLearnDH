using CSharpCourseDH.FirstTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;


namespace TestProject1.CSharpCourseDHTests
{

    /// <summary>
    /// The test class for CVehicle
    /// </summary>

    [TestFixture]
    public class CVehicleTest
    {
        CVehicle vehicle = new CVehicle("235135421", "TestManufacturer",
            "TestModel", 1976, 100000, true, 333.99);
        
        [Test]
        public void TestConstructor()
        {
            var id = "235135421";
            var manufacturer = "TestManufacturer";
            var mileage = 100000;
            var newTestManufacturer = "Mercedes";

            Assert.That(id, Is.EqualTo(vehicle.Id));
            Assert.That(manufacturer, Is.EqualTo(vehicle.Manufacturer));
            Assert.That(mileage, Is.EqualTo(vehicle.Mileage));
            
            vehicle.Manufacturer = newTestManufacturer;
            
            Assert.That(newTestManufacturer, Is.EqualTo(vehicle.Manufacturer));
        }


        [Test]
        public void CalculateRentalCostTest()
        {
            var rentalCostTwoDays = 333.99 * 2;
            
            Assert.That(vehicle.CalculateRentalCost(2), Is.EqualTo(rentalCostTwoDays));
        }
    }
}