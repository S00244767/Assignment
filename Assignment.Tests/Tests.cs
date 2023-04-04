using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment.Tests
{
    internal class Tests
    {
        [TestFixture]
        public class WeatherForecastTests
        {
            [Test]
            public void CalcPremium_Where_Age_Under_18_And_Rural()
            {
                //Arrange
                var mockWeatherService = new Mock<IDiscountService>();
                mockWeatherService.Setup(x => x.GetDiscount()).Returns(0.7);
                var weatherForecast = new InsuranceService(mockWeatherService.Object);

                //Act
                double premium = weatherForecast.CalcPremium(16, "rural");

                //Assert
                Assert.That(premium, Is.EqualTo(0.0));
            }

            [Test]
            public void CalcPremium_Where_Age_Over_31_And_Rural()
            {
                //Arrange
                var mockWeatherService = new Mock<IDiscountService>();
                mockWeatherService.Setup(x => x.GetDiscount()).Returns(0.7);
                var weatherForecast = new InsuranceService(mockWeatherService.Object);

                //Act
                double premium = weatherForecast.CalcPremium(37, "rural");

                //Assert
                Assert.That(premium, Is.EqualTo(2.5));
            }

            [Test]
            public void CalcPremium_Where_Age_Between_18_And_30_And_Rural()
            {
                //Arrange
                var mockWeatherService = new Mock<IDiscountService>();
                mockWeatherService.Setup(x => x.GetDiscount()).Returns(0.7);
                var weatherForecast = new InsuranceService(mockWeatherService.Object);

                //Act
                double premium = weatherForecast.CalcPremium(21, "rural");

                //Assert
                Assert.That(premium, Is.EqualTo(5.0));
            }

            [Test]
            public void CalcPremium_Where_Age_Under_18_And_Urban()
            {
                //Arrange
                var mockWeatherService = new Mock<IDiscountService>();
                mockWeatherService.Setup(x => x.GetDiscount()).Returns(0.7);
                var weatherForecast = new InsuranceService(mockWeatherService.Object);

                //Act
                double premium = weatherForecast.CalcPremium(16, "urban");

                //Assert
                Assert.That(premium, Is.EqualTo(0.0));
            }

            [Test]
            public void CalcPremium_Where_Age_Over_36_And_Urban()
            {
                //Arrange
                var mockWeatherService = new Mock<IDiscountService>();
                mockWeatherService.Setup(x => x.GetDiscount()).Returns(0.7);
                var weatherForecast = new InsuranceService(mockWeatherService.Object);

                //Act
                double premium = weatherForecast.CalcPremium(39, "urban");

                //Assert
                Assert.That(premium, Is.EqualTo(5.0));
            }

            [Test]
            public void CalcPremium_Where_Age_Between_18_And_35_And_Urban()
            {
                //Arrange
                var mockWeatherService = new Mock<IDiscountService>();
                mockWeatherService.Setup(x => x.GetDiscount()).Returns(0.7);
                var weatherForecast = new InsuranceService(mockWeatherService.Object);

                //Act
                double premium = weatherForecast.CalcPremium(21, "urban");

                //Assert
                Assert.That(premium, Is.EqualTo(6.0));
            }
            [Test]
            public void CalcPremium_Where_Age_Over_50_And_Nowhere()
            {
                //Arrange
                var mockWeatherService = new Mock<IDiscountService>();
                mockWeatherService.Setup(x => x.GetDiscount()).Returns(0.7);
                var weatherForecast = new InsuranceService(mockWeatherService.Object);

                //Act
                double premium = weatherForecast.CalcPremium(64, "nowhere");

                //Assert
                Assert.That(premium, Is.EqualTo(0.0));
            }
        }
    }
}
