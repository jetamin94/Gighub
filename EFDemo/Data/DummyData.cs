using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo.Data
{
    public class DummyData
    {
        public static List<Team> GetTeams()
        {
            var teams = new List<Team>
            {
                new Team() {
                    Name = "team_1",
                    City = "HN" },
                new Team() {
                    Name = "team_2",
                    City = "HCM" },
                new Team() {
                    Name = "team_3",
                    City = "BK" },
            };
            return teams;
        }

        public static List<Player> GetPlayers()
        {
            var players = new List<Player>
            {
                new Player() {
                    Name = "player_1", 
                    Dob = new DateTime(2017, 1, 11)
                },
                new Player() {
                    Name = "player_2",
                    Dob = new DateTime(2017, 2, 11)
                },
                new Player() {
                    Name = "player_3",
                    Dob = new DateTime(2017, 3, 11)
                },
                new Player() {
                    Name = "player_4",
                    Dob = new DateTime(2017, 4, 11)
                },
                new Player() {
                    Name = "player_5",
                    Dob = new DateTime(2017, 5, 11)
                },
            };
            return players;
        }
    }
}