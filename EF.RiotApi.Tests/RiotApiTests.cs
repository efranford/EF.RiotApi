using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF.RiotApi.Client;
using System.Collections.Generic;
using EF.RiotApi.Dto;
using EF.RiotApi.WebRequestResults;

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
            var getChampsResult = RiotWeb.API.GetChampions();
            Assert.IsTrue(getChampsResult.Champions.Count > 0);
        }

        [TestMethod]
        public void TestGetChampionsAsync()
        {
            var getChampsResult = RiotWeb.API.GetChampionsAsync();
            Assert.IsTrue(getChampsResult.Result.Champions.Count > 0);
        }

        [TestMethod]
        public void TestGetRecentGames()
        {
            var getRecentGamesresult = RiotWeb.API.GetGamesBySummonerAsync(32144);
            Assert.IsTrue(getRecentGamesresult.Result.Games.Count > 0);
        }
        
        [TestMethod]
        public void TestGetLeagues()
        {
            var getLeagues = RiotWeb.API.GetLeagueBySummonerAsync(32144);
            var result = getLeagues.Result;
            Assert.IsTrue(result.Keys.Count > 0);
        }

        [TestMethod]
        public void TestGetPlayerStatsSummary()
        {
            var getRecentGamesresult = RiotWeb.API.GetPlayerStatsSummary(32144);
            Assert.IsTrue(getRecentGamesresult.PlayerStatSummaries.Count > 0);
        }

        [TestMethod]
        public void TestGetPlayerStatsSummaryAsync()
        {
            var getRecentGamesresult = RiotWeb.API.GetPlayerStatsSummaryAsync(32144);
            var result = getRecentGamesresult.Result;
            Assert.IsTrue(result.PlayerStatSummaries.Count > 0);
        }
    }
}
