using System;
using Product.Api;
using Xunit;

namespace Product.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void TemperatureF_ShouldReturnCorrectValue_WhenTemperatureCIsZero()
        {
            var forecast = new WeatherForecast { TemperatureC = 0 };
            int expected = 32;

            Assert.Equal(expected, forecast.TemperatureF);
        }

        [Theory]
        [InlineData(-40, -40)]
        [InlineData(100, 212)]
        [InlineData(20, 68)]
        public void TemperatureF_ShouldConvertCelsiusToFahrenheit(int tempC, int expectedF)
        {
            var forecast = new WeatherForecast { TemperatureC = tempC };
            Assert.Equal(expectedF, forecast.TemperatureF);
        }

        [Fact]
        public void Summary_ShouldBeSetAndRetrievedCorrectly()
        {
            var forecast = new WeatherForecast { Summary = "Partly Cloudy" };
            Assert.Equal("Partly Cloudy", forecast.Summary);
        }

        [Fact]
        public void Date_ShouldHoldAssignedDate()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var forecast = new WeatherForecast { Date = today };
            Assert.Equal(today, forecast.Date);
        }
    }
}