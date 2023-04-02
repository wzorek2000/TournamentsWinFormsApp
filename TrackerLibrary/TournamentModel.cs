using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal EntryFee { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        
        /// <summary>
        /// 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        
        /// <summary>
        /// 
        /// </summary>
        public List<MatchupModel> Rounds { get; set; } = new List<MatchupModel>();
    }
}