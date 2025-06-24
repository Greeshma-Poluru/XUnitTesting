using Category.Api.Model;
namespace Products.Infrastructure.Test.Model
{
    public class CalculatorTest
    {
        [Fact] 
        public void Add_Returnsum()
        {
            int a = 10;
            int b = 10;

            var result = new Calculator();
            var sumresult = result.Add(a, b);
            Assert.Equal(20, sumresult);
        }

        [Fact]
        public void Sub_Returnsub()
        {
            int a = 10;
            int b = 10;

            var result = new Calculator();
            var sumresult = result.Sub(a, b);
            Assert.Equal(0, sumresult);
        }

        [Fact]
        public void Mul_Returnmul()
        {
            int a = 10;
            int b = 10;

            var result = new Calculator();
            var sumresult = result.Mul(a, b);
            Assert.Equal(100, sumresult);
        }

        [Fact]
        public void Div_Returndiv()
        {
            int a = 10;
            int b = 10;

            var result = new Calculator();
            var sumresult = result.Div(a, b);
            Assert.Equal(1, sumresult);
        }
    }
}
