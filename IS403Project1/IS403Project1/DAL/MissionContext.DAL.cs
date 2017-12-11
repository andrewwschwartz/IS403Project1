using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IS403Project1.Models;
using System.Data.Entity;

namespace IS403Project1.DAL
{
    public class MissionContext: DbContext
    {
        public MissionContext() : base("MissionContext")
        {

        }

        public DbSet<Missions> Brothers { get; set; }
        public DbSet<MissionQuestions> MissionQuestion { get; set; }
        public DbSet<users> user { get; set; }
        public DbSet<MissionAndQuestions> missionAndQuestion { get; set; }

    }
}