using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FBLCodeFrst.Models
{
    [Table("FootballMatches")]
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public string TeamName1 { get; set; }

        public string TeamName2 { get; set; }

        public string WinningTeam { get; set; }

        public string Status { get; set; }  

        public int Points { get; set; }
        
    }
}