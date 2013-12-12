using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF.RiotApi.Client;

namespace EF.RiotApi.Tests
{
    [TestClass]
    public class RiotApiests
    {
        [TestMethod]
        public void TestApiSettings()
        {
           Assert.IsNotNull(RiotWeb.API);
           Assert.IsTrue(!string.IsNullOrEmpty(RiotWeb.API.ApiKey));
           Assert.IsTrue(!string.IsNullOrEmpty(RiotWeb.API.ApiLocation));
           Assert.IsTrue(!string.IsNullOrEmpty(RiotWeb.API.ApiRegion));
           Assert.IsTrue(!string.IsNullOrEmpty(RiotWeb.API.ApiUrl));
           Assert.IsTrue(!string.IsNullOrEmpty(RiotWeb.API.ApiVerision));
        }

        [TestMethod]
        public void TestGetChampions()
        {
            var champs = RiotWeb.API.GetChampions();
            Assert.IsTrue(champs.Count > 0);
        }

        [TestMethod]
        public void TestGetChampionsAsync()
        {
            var champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
        }

        [TestMethod]
        public void TestCaching()
        {
            var champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
            champs = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(champs.Result.Count > 0);
        }
    }
}
