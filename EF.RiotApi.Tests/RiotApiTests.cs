using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EF.RiotApi.Client;

namespace EF.RiotApi.Tests
{
    [TestClass]
    public class RiotApiests
    {

        #region Api Settings

        [TestMethod]
        [TestCategory("API Settings")]
        public void TestApiInit()
        {
           Assert.IsNotNull(RiotWeb.API);
        }

        #endregion

        #region Champion Api Tests

        [TestMethod]
        [TestCategory("Champion Api")]
        public void TestGetChampions()
        {
            var getChampsResult = RiotWeb.API.Champion.GetChampions();
            Assert.IsTrue(getChampsResult.Champions.Count > 0);
        }

        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Champion Api")]
        [TestCategory("Async Tests")]
        public void TestGetChampionsAsync()
        {
            var getChampsResult = RiotWeb.API.Champion.GetChampionsAsync();
            Assert.IsTrue(getChampsResult.Result.Champions.Count > 0);
        }
#endif

        #endregion

        #region Game Api Tests

        [TestMethod]
        [TestCategory("Game Api")]
        public void TestGetRecentGames()
        {
            var getRecentGamesresult = RiotWeb.API.Game.GetGamesBySummoner(32144);
            Assert.IsTrue(getRecentGamesresult.Games.Count > 0);
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Game Api")]
        [TestCategory("Async Tests")]
        public void TestGetRecentGamesAsync()
        {
            var getRecentGamesresult = RiotWeb.API.Game.GetGamesBySummonerAsync(32144);
            Assert.IsTrue(getRecentGamesresult.Result.Games.Count > 0);
        }
#endif

        #endregion

        #region League Api Tests

        [TestMethod]
        [TestCategory("League Api")]
        public void TestGetLeagues()
        {
            var getLeagues = RiotWeb.API.League.GetLeagueBySummoner(32144);
            Assert.IsTrue(getLeagues.Keys.Count > 0);
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("League Api")]
        [TestCategory("Async Tests")]
        public void TestGetLeaguesAsync()
        {
            var getLeagues = RiotWeb.API.League.GetLeagueBySummonerAsync(32144);
            var result = getLeagues.Result;
            Assert.IsTrue(result.Keys.Count > 0);
        }
#endif


        #endregion

        #region Stats Api Tests

        [TestMethod]
        [TestCategory("Stats Api")]
        public void TestGetPlayerStatsSummary()
        {
            var getRecentGamesresult = RiotWeb.API.Stats.GetPlayerStatsSummary(32144);
            Assert.IsTrue(getRecentGamesresult.PlayerStatSummaries.Count > 0);
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Stats Api")]
        [TestCategory("Async Tests")]
        public void TestGetPlayerStatsSummaryAsync()
        {
            var getRecentGamesresult = RiotWeb.API.Stats.GetPlayerStatsSummaryAsync(32144);
            var result = getRecentGamesresult.Result;
            Assert.IsTrue(result.PlayerStatSummaries.Count > 0);
        }
#endif

        #endregion

        #region Summoner Api Tests

        [TestMethod]
        [TestCategory("Summoner Api")]
        public void TestGetSummonerRunes()
        {
            var getSummonerRunes = RiotWeb.API.Summoner.GetSummonerRunes(32144);
            Assert.IsTrue(getSummonerRunes.Pages.Count > 0);
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Summoner Api")]
        [TestCategory("Async Tests")]
        public void TestGetSummonerRunesAsync()
        {
            var getSummonerRunes = RiotWeb.API.Summoner.GetSummonerRunesAsync(32144);
            var result = getSummonerRunes.Result;
            Assert.IsTrue(result.Pages.Count > 0);
        }
#endif

        [TestMethod]
        [TestCategory("Summoner Api")]
        public void TestGetSummonerMasteries()
        {
            var getSummonerMasteries = RiotWeb.API.Summoner.GetSummonerMasteries(32144);
            Assert.IsTrue(getSummonerMasteries.Pages.Count > 0);
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Summoner Api")]
        [TestCategory("Async Tests")]
        public void TestGetSummonerMasteriesAsync()
        {
            var getSummonerMasteries = RiotWeb.API.Summoner.GetSummonerMasteriesAsync(32144);
            var result = getSummonerMasteries.Result;
            Assert.IsTrue(result.Pages.Count > 0);
        }
#endif

        [TestMethod]
        [TestCategory("Summoner Api")]
        public void TestGetSummonerById()
        {
            var getSummoner = RiotWeb.API.Summoner.GetSummoner(32144);
            Assert.IsTrue(getSummoner.Name == "Dome");
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Summoner Api")]
        [TestCategory("Async Tests")]
        public void TestGetSummonerByIdAsync()
        {
            var getSummoner = RiotWeb.API.Summoner.GetSummonerAsync(32144);
            var result = getSummoner.Result;
            Assert.IsTrue(result.Name == "Dome");
        }
#endif

        [TestMethod]
        [TestCategory("Summoner Api")]
        public void TestGetSummonerByName()
        {
            var getSummoner = RiotWeb.API.Summoner.GetSummoner("Dome");
            Assert.IsTrue(getSummoner.Id == 32144);
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Summoner Api")]
        [TestCategory("Async Tests")]
        public void TestGetSummonerByNameAsync()
        {
            var getSummoner = RiotWeb.API.Summoner.GetSummonerAsync("Dome");
            var result = getSummoner.Result;
            Assert.IsTrue(result.Id == 32144);
        }
#endif

        [TestMethod]
        [TestCategory("Summoner Api")]
        public void TestGetSummoners()
        {
            var ids ="32144,32145,32146";
            var listIds = new List<long> { 32144, 32145, 32146 };
            var getSummoner = RiotWeb.API.Summoner.GetSummoners(ids);
            getSummoner.Summoners.ForEach((summoner) =>
            {
                Assert.IsTrue(listIds.Contains(summoner.Id));
            });
        }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Summoner Api")]
        [TestCategory("Async Tests")]
        public void TestGetSummonersAsync()
        {
            var ids = "32144,32145,32146";
            var listIds = new List<long> { 32144, 32145, 32146 };
            var getSummoners = RiotWeb.API.Summoner.GetSummonersAsync(ids);
            var result = getSummoners.Result;
            result.Summoners.ForEach((summoner) =>
            {
                Assert.IsTrue(listIds.Contains(summoner.Id));
            });
        }
#endif

        #endregion

        #region Team Api

        [TestMethod]
        [TestCategory("Team Api")]
        public void GetTeamsBySummoner()
        {
            var getTeams = RiotWeb.API.Team.GetSummonerTeams(32144);
            Assert.IsTrue(getTeams.Count > 0);
         }
        
#if NET35 || NET40 || NET45 || NET451
        [TestMethod]
        [TestCategory("Team Api")]
        [TestCategory("Async Tests")]
        public void GetTeamsBySummonerAsync()
        {
            var getTeams = RiotWeb.API.Team.GetSummonerTeamsAsync(32144);
            Assert.IsTrue(getTeams.Result.Count > 0);
        }
#endif


        #endregion
    }
}
