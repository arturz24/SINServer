using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SINServer.Models {
    public class ScoreContext : DbContext{
        public ScoreContext() : base("SinServer") {

        }
        public DbSet<Score> userScores { get; set; }
        public DbSet<User> users { get; set; }
    }
}