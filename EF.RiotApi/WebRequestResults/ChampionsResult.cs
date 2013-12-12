using EF.RiotApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.WebRequestResults
{
    public class ChampionsResult 
    {
        public List<ChampionDto> Champions { get; set; }
    }
}
