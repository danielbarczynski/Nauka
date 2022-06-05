using System.Text;

namespace Naukaa97_xUnit_
{
    public class StringBuilderTest
    {
        [Fact]
        public void Append_ForTwoStrings_ReturnsConcatenatedStrings()
        {
            // arrange

            StringBuilder  sb = new StringBuilder();

            // act

            sb.Append("test").Append("test2");
            string result = sb.ToString();
            // assert 

            Assert.Equal("testtest2", result);
        }
    }
}