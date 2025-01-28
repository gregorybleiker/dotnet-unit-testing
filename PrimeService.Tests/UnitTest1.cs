//using Xunit;
using PrimeService;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs2_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(2);

            Assert.False(result, "2 should not be prime");
        }
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}