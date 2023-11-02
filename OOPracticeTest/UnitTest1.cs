namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Theory]
        [InlineData("cool car",30)]
        public void Should_show_name_speed_when_speedup_given_name_speed(string name,int speed)
        {

            Base car1 = new Car(name,speed);
            string result = car1.CarSpeedUp();

            Assert.Equal("cool car: speed up 30km/h",result);
        }

        [Theory]
        [InlineData("big truck", 10)]
        public void Should_show_name_speed_when_speedup_given_name_speed2(string name, int speed)
        {

            Base truck1 = new Truck(name, speed);
            string result = truck1.CarSpeedUp();

            Assert.Equal("big truck: speed up 10km/h", result);
        }
        [Theory]
        [InlineData("cool car", 30)]
        public void Should_show_name_speed_when_driver_speedup_given_name_speed2(string name, int speed)
        {

            var car = new Car(name,speed);
            Driver driver = new Driver();
            string result = driver.Drive(car);


            Assert.Equal("cool car: speed up 30km/h", result);

        }
        [Theory]
        [InlineData("big truck", 10)]
        public void Should_show_name_speed_when_driver_speedup_given_name_speed3(string name, int speed)
        {

            var truck = new Truck(name, speed);
            Driver driver = new Driver();
            string result = driver.Drive(truck);
            Assert.Equal("big truck: speed up 10km/h", result);
        }
    }

}
