using ContosoCrafts.WebSite.Services;
using ContosoCrafts.WebSite.Models;
using Moq;
using Microsoft.AspNetCore.Hosting;

namespace ContosoCraftsTest
{
    public class JsonFileProductServiceTest
    {
        [Fact]
        public void Test1()
        {
            int expectect = 4;
            int actual = 2 + 2;
            Assert.Equal(expectect, actual);
        }

        [Fact]
        public void Test2()
        {
            bool expectect = true;
            Assert.True(expectect);
        }
    }
}