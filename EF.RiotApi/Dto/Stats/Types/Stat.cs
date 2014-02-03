using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Stats.Types
{
    /// <summary>
    /// Stat types
    /// </summary>
    public class StatTypes
    {
        /// <summary>
        /// Stat types for ARAM
        /// </summary>
        public enum AramUnranked5x5
        {
            /// <summary>
            /// Total turrets killed
            /// </summary>
            TOTAL_TURRETS_KILLED,
            /// <summary>
            /// Total assists
            /// </summary>
            TOTAL_ASSISTS,
            /// <summary>
            /// Total champion kills
            /// </summary>
            TOTAL_CHAMPION_KILLS
        }
        
        /// <summary>
        /// Stat types for coop vs ai
        /// </summary>
        public enum CoopVsAI
        {
            TOTAL_TURRETS_KILLED,
            MAX_OBJECTIVE_PLAYER_SCORE,
            MAX_ASSISTS,
            MAX_NODE_CAPTURE_ASSIST,
            AVERAGE_CHAMPIONS_KILLED,
            AVERAGE_NODE_CAPTURE_ASSIST,
            TOTAL_CHAMPION_KILLS,
            MAX_TOTAL_PLAYER_SCORE,
            AVERAGE_ASSISTS,
            MAX_TEAM_OBJECTIVE,
            TOTAL_MINION_KILLS,
            AVERAGE_COMBAT_PLAYER_SCORE,
            TOTAL_ASSISTS,
            MAX_NODE_CAPTURE,
            AVERAGE_NODE_NEUTRALIZE_ASSIST,
            TOTAL_NEUTRAL_MINIONS_KILLED,
            MAX_NODE_NEUTRALIZE_ASSIST,
            AVERAGE_NODE_NEUTRALIZE,
            AVERAGE_TEAM_OBJECTIVE,
            AVERAGE_OBJECTIVE_PLAYER_SCORE,
            MAX_NODE_NEUTRALIZE,
            TOTAL_NODE_NEUTRALIZE,
            AVERAGE_TOTAL_PLAYER_SCORE,
            MAX_COMBAT_PLAYER_SCORE,
            AVERAGE_NODE_CAPTURE,
            AVERAGE_NUM_DEATHS,
            TOTAL_NODE_CAPTURE,
            MAX_CHAMPIONS_KILLED
        }

        /// <summary>
        /// Stat types for dominion unranked
        /// </summary>
        public enum OdinUnranked
        {
            MAX_OBJECTIVE_PLAYER_SCORE,
            MAX_ASSISTS,
            MAX_NODE_CAPTURE_ASSIST,
            AVERAGE_CHAMPIONS_KILLED,
            AVERAGE_NODE_CAPTURE_ASSIST,
            MAX_TOTAL_PLAYER_SCORE,
            TOTAL_CHAMPION_KILLS,
            AVERAGE_ASSISTS,
            MAX_TEAM_OBJECTIVE,
            AVERAGE_COMBAT_PLAYER_SCORE,
            TOTAL_ASSISTS,
            MAX_NODE_CAPTURE,
            AVERAGE_NODE_NEUTRALIZE_ASSIST,
            MAX_NODE_NEUTRALIZE_ASSIST,
            AVERAGE_NODE_NEUTRALIZE,
            AVERAGE_TEAM_OBJECTIVE,
            AVERAGE_OBJECTIVE_PLAYER_SCORE,
            MAX_NODE_NEUTRALIZE,
            TOTAL_NODE_NEUTRALIZE,
            AVERAGE_TOTAL_PLAYER_SCORE,
            MAX_COMBAT_PLAYER_SCORE,
            AVERAGE_NODE_CAPTURE,
            AVERAGE_NUM_DEATHS,
            TOTAL_NODE_CAPTURE,
            MAX_CHAMPIONS_KILLED
        }

        /// <summary>
        /// Stat types for ranked premade 3x3
        /// </summary>
        public enum RankedPremade3x3
        {
            TOTAL_NEUTRAL_MINIONS_KILLED,
            TOTAL_TURRETS_KILLED,
            TOTAL_MINION_KILLS,
            TOTAL_ASSISTS,
            TOTAL_CHAMPION_KILLS
        }

        /// <summary>
        /// Stat types for ranked premade 5x5
        /// </summary>
        public enum RankedPremade5x5
        {
            TOTAL_NEUTRAL_MINIONS_KILLED,
            TOTAL_TURRETS_KILLED,
            TOTAL_MINION_KILLS,
            TOTAL_ASSISTS,
            TOTAL_CHAMPION_KILLS
        }

        /// <summary>
        /// Stat types for ranked solo 5x5
        /// </summary>
        public enum RankedSolo5x5
        {
            TOTAL_NEUTRAL_MINIONS_KILLED,
            TOTAL_TURRETS_KILLED,
            TOTAL_MINION_KILLS,
            TOTAL_ASSISTS,
            TOTAL_CHAMPION_KILLS
        }

        /// <summary>
        /// Stat types for solo 3x3
        /// </summary>
        public enum RankedTeam3x3
        {
            TOTAL_NEUTRAL_MINIONS_KILLED,
            TOTAL_TURRETS_KILLED,
            TOTAL_MINION_KILLS,
            TOTAL_ASSISTS,
            TOTAL_CHAMPION_KILLS
        }

        /// <summary>
        /// Stat types for ranked ranked team 5x5
        /// </summary>
        public enum RankedTeam5x5
        {
            TOTAL_NEUTRAL_MINIONS_KILLED,
            TOTAL_TURRETS_KILLED,
            TOTAL_MINION_KILLS,
            TOTAL_ASSISTS,
            TOTAL_CHAMPION_KILLS
        }

        /// <summary>
        /// Stat types for unranked play
        /// </summary>
        public enum Unranked
        {
            TOTAL_NEUTRAL_MINIONS_KILLED,
            TOTAL_TURRETS_KILLED,
            TOTAL_MINION_KILLS,
            TOTAL_ASSISTS,
            TOTAL_CHAMPION_KILLS
        }

        /// <summary>
        /// Stat types for unranked 3x3 play
        /// </summary>
        public enum Unranked3x3
        {
            TOTAL_NEUTRAL_MINIONS_KILLED,
            TOTAL_TURRETS_KILLED,
            TOTAL_MINION_KILLS,
            TOTAL_ASSISTS,
            TOTAL_CHAMPION_KILLS
        }
    }
}
