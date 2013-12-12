using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto
{
    public class ChampionDto
    {
        bool active { get; set; }               //	Indicates if the champion is active.
        int attackRank { get; set; }            //	Champion attack rank.
        bool botEnabled { get; set; }           //  Bot enabled flag (for custom games).
        bool botMmEnabled { get; set; }         //  Bot Match Made enabled flag (for Co-op vs. AI games).
        int defenseRank { get; set; }           //  Champion defense rank.
        int difficultyRank { get; set; }        //  Champion difficulty rank.
        bool freeToPlay { get; set; }           //  Indicates if the champion is free to play. Free to play champions are rotated periodically.
        long id { get; set; }                   //  Champion ID.
        int magicRank { get; set; }             //  Champion magic rank.
        string name { get; set; }               //  Champion name.
        bool rankedPlayEnabled { get; set; }    //	Ranked play enabled flag.
    }
}
