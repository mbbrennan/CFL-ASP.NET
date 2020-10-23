using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CFLv2.Models
{
    public class CFLDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CFLDBContext(DbContextOptions<CFLDBContext> options)
        : base(options)
        { }

        public CFLDBContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    ID = 1,
                    Abbrev = "BC",
                    LongName = "BC Lions",
                    City = "Vancouver",
                    Stadium = "BC Place"
                }
                ,
                new Team
                {
                    ID = 2,
                    Abbrev = "EDM",
                    LongName = "Edmonton Eskimos",
                    City = "Edmonton",
                    Stadium = "Commonweath Stadium"
                }
                ,
                new Team
                {
                    ID = 3,
                    Abbrev = "CGY",
                    LongName = "Calgary Stampeders",
                    City = "Calgary",
                    Stadium = "McMahon Stadium"
                }
                ,
                new Team
                {
                    ID = 4,
                    Abbrev = "SSK",
                    LongName = "Saskatchewan Roughriders",
                    City = "Regina",
                    Stadium = "Mosaic Stadium"
                }
                ,
                new Team
                {
                    ID = 5,
                    Abbrev = "WPG",
                    LongName = "Winnipeg Blue Bombers",
                    City = "Winnipeg",
                    Stadium = "Investors Group Field"
                }
                ,
                new Team
                {
                    ID = 6,
                    Abbrev = "TOR",
                    LongName = "Toronto Argonauts",
                    City = "Toronto",
                    Stadium = "BMO Field"
                }
                ,
                new Team
                {
                    ID = 7,
                    Abbrev = "HAM",
                    LongName = "Hamilton Tiger-Cats",
                    City = "Hamilton",
                    Stadium = "Tim Hortons Field"
                }
                ,
                new Team
                {
                    ID = 8,
                    Abbrev = "OTT",
                    LongName = "Ottawa Redblacks",
                    City = "Ottawa",
                    Stadium = "TD Place Stadium"
                }
                ,
                new Team
                {
                    ID = 9,
                    Abbrev = "MTL",
                    LongName = "Montreal Alouettes",
                    City = "Montreal",
                    Stadium = "Percival Molson Memorial Stadium"
                }
            );
            modelBuilder.Entity<Season>().HasData(
                new Season
                {
                    ID = 60,
                    SeasonID = 2018,
                    SeasonName = "2018"
                }
            );
            modelBuilder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ID = 1,
                    GameDate = new DateTime(2018, 6, 14, 19,00,00,0),
                    Week = "1",
                    AwayTeam = "EDM",
                    HomeTeam = "WPG",
                    AwayPoints = 33,
                    HomePoints = 30,
                    Attendance = 25458
                }
                ,
                new Schedule
                {
                    ID = 2,
                    GameDate = new DateTime(2018, 6, 15, 19, 00, 00, 0),
                    Week = "1",
                    AwayTeam = "TOR",
                    HomeTeam = "SSK",
                    AwayPoints = 19,
                    HomePoints = 27,
                    Attendance = 29788
                }
                ,
                new Schedule
                {
                    ID = 3,
                    GameDate = new DateTime(2018, 6, 16, 19, 00, 00, 0),
                    Week = "1",
                    AwayTeam = "HAM",
                    HomeTeam = "CGY",
                    AwayPoints = 14,
                    HomePoints = 28,
                    Attendance = 23717
                }
                ,
                new Schedule
                {
                    ID = 4,
                    GameDate = new DateTime(2018, 6, 16, 19, 00, 00, 0),
                    Week = "1",
                    AwayTeam = "MTL",
                    HomeTeam = "BC",
                    AwayPoints = 10,
                    HomePoints = 22,
                    Attendance = 20182
                }
                ,
                new Schedule
                {
                    ID = 5,
                    GameDate = new DateTime(2018, 6, 21, 19, 00, 00, 0),
                    Week = "2",
                    AwayTeam = "SSK",
                    HomeTeam = "OTT",
                    AwayPoints = 17,
                    HomePoints = 40,
                    Attendance = 24224
                }
                ,
                new Schedule
                {
                    ID = 6,
                    GameDate = new DateTime(2018, 6, 22, 19, 00, 00, 0),
                    Week = "2",
                    AwayTeam = "WPG",
                    HomeTeam = "MTL",
                    AwayPoints = 56,
                    HomePoints = 10,
                    Attendance = 19498
                }
                ,
                new Schedule
                {
                    ID = 7,
                    GameDate = new DateTime(2018, 6, 22, 19, 00, 00, 0),
                    Week = "2",
                    AwayTeam = "HAM",
                    HomeTeam = "EDM",
                    AwayPoints = 38,
                    HomePoints = 21,
                    Attendance = 31334
                }
                ,
                new Schedule
                {
                    ID = 8,
                    GameDate = new DateTime(2018, 6, 23, 19, 00, 00, 0),
                    Week = "2",
                    AwayTeam = "CGY",
                    HomeTeam = "TOR",
                    AwayPoints = 41,
                    HomePoints = 7,
                    Attendance = 16450
                }
            );

            modelBuilder.Entity<Standing>().HasData(
                new Standing
                {
                    ID = 1,
                    //TeamID = 1,
                    Rank = 0,
                    LongName = "BC Lions",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord ="",
                    InDiv = ""
                }
                ,
                new Standing
                {
                    ID = 2,
                    //TeamID = 2,
                    Rank = 0,
                    LongName = "Edmonton",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                }
                ,
                new Standing
                {
                    ID = 3,
                    //TeamID = 3,
                    Rank = 0,
                    LongName = "Calgary",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                },
                new Standing
                {
                    ID = 4,
                    //TeamID = 4,
                    Rank = 0,
                    LongName = "Saskatchewan",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                }
                ,
                new Standing
                {
                    ID = 5,
                    //TeamID = 5,
                    Rank = 0,
                    LongName = "Winnipeg",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                }
                ,
                new Standing
                {
                    ID = 6,
                    //TeamID = 6,
                    Rank = 0,
                    LongName = "Toronto",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                }
                ,
                new Standing
                {
                    ID = 7,
                    //TeamID = 7,
                    Rank = 0,
                    LongName = "Hamilton",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                }
                ,
                new Standing
                {
                    ID = 8,
                    //TeamID = 8,
                    Rank = 0,
                    LongName = "Ottawa",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                }
                ,
                new Standing
                {
                    ID = 9,
                    //TeamID = 9,
                    Rank = 0,
                    LongName = "Montreal",
                    GP = 0,
                    Wins = 0,
                    Loses = 0,
                    Ties = 0,
                    Points = 0,
                    PointsFor = 0,
                    PointsAgainst = 0,
                    HomeWins = 0,
                    HomeRecord = "",
                    AwayWins = 0,
                    AwayRecord = "",
                    InDiv = ""
                }
          );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CFLDB;Trusted_Connection=True;ConnectRetryCount=0");
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Standing> Standings { get; set; }
    }

    public class Team
    {
        [Key]
        public int ID { get; set; }
        public string Abbrev { get; set; }
        [Display(Name = "Full Name")]
        public string LongName { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Stadium")]
        public string Stadium { get; set; }
    }

    public class Season
    {
        [Key]
        public int ID { get; set; }
        public int SeasonID { get; set; }
        [Display(Name = "Season")]
        public string SeasonName { get; set; }
    }

    public class Schedule
    {
        [Key]
        public int ID { get; set; }
        public string Week { get; set; }
        [Display(Name = "Date")]
        public DateTime GameDate { get; set; }
        [Display(Name = "Road Team")]
        public string AwayTeam { get; set; }
        [Display(Name = "Home Team")]
        public string HomeTeam { get; set; }
        [Display(Name = "Road Pts")]
        public int AwayPoints { get; set; }
        [Display(Name = "Home Pts")]
        public int HomePoints { get; set; }
        public int Attendance { get; set; }
    }

    public class Standing
    {
        [Key]
        public int ID { get; set; }
     //   public int TeamID { get; set; }
        [Display(Name = "Rank")]
        public int Rank { get; set; }
        [Display(Name = "Team")]
        public string LongName { get; set; }
        [Display(Name = "Games Played")]
        public int GP { get; set; }
        [Display(Name = "Wins")]
        public int Wins { get; set; }
        [Display(Name = "Losses")]
        public int Loses { get; set; }
        [Display(Name = "Ties")]
        public int Ties { get; set; }
        [Display(Name = "Points")]
        public int Points { get; set; }
        [Display(Name = "Points For")]
        public int PointsFor { get; set; }
        [Display(Name = "Points Against")]
        public int PointsAgainst { get; set; }
        [Display(Name = "Home Wins")]
        public int HomeWins { get; set; }
        [Display(Name = "Home Record")]
        public string HomeRecord { get; set; }
        [Display(Name = "Away Wins")]
        public int AwayWins { get; set; }
        [Display(Name = "Away Record")]
        public string AwayRecord { get; set; }
        [Display(Name = "Within Division")]
        public string InDiv { get; set; }
    }
}