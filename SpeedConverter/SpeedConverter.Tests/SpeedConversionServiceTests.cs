using SpeedConverter.Code;
using System;
using Xunit;

namespace SpeedConverter.Tests
{
    public class SpeedConversionServiceTests : IDisposable
    {
        private readonly SpeedConversionService speedConverter;

        public SpeedConversionServiceTests()
        {
            speedConverter = new SpeedConversionService();
        }

        [Fact]
        public void ConvertToMilesPerHour_0_0()
        {
            // act
            var milesPerHour = speedConverter.ConvertToMilesPerHour(0);

            // assert
            Assert.Equal(0, milesPerHour);
        }

        [Fact]
        public void ConvertToMilesPerHour_10_6()
        {
            var milesPerHour = speedConverter.ConvertToMilesPerHour(10);

            Assert.Equal(6, milesPerHour);
        }

        [Fact]
        public void ConvertToMilesPerHour_11_7()
        {
            var milesPerHour = speedConverter.ConvertToMilesPerHour(11);

            Assert.Equal(7, milesPerHour);
        }

        public void Dispose()
        {
            // no-op
        }
    }
}
