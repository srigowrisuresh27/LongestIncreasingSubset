using LongestIncreasingService;

namespace LISTest
{

    public class LisServiceTests
    {
        private readonly LongestIncreasingServiceClass _service;

        public LisServiceTests()
        {
            _service = new LongestIncreasingServiceClass();
        }

        [Fact]
        public void ReturnsCorrectLIS_ForTestCase1()
        {
            var input = "6 1 5 9 2";
            var expected = new List<int> { 1, 5, 9 };

            var result = _service.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnsCorrectLIS_ForTestCase2()
        {
            var input = "10 20 10 30 20 50";
            var expected = new List<int> { 10, 20, 30, 50 };

            var result = _service.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnsEmpty_ForEmptyInput()
        {
            var input = "";
            var expected = new List<int>();

            var result = _service.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnsSingleElement_ForSingleNumber()
        {
            var input = "42";
            var expected = new List<int> { 42 };

            var result = _service.GetLongestIncreasingSubsequence(input);

            Assert.Equal(expected, result);
        }
    }
}
