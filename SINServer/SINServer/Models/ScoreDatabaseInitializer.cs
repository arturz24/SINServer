using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SINServer.Models {
    public class ScoreDatabaseInitializer : DropCreateDatabaseAlways<ScoreContext>{
        protected override void Seed(ScoreContext context) {
            GetUsers().ForEach(c => context.users.Add(c));
            GetScores().ForEach(c => context.userScores.Add(c));
        }
        private static List<User> GetUsers() {
            var users = new List<User>{
                new User {
                    ID = 1,
                    login = "Daj"
                },
                new User {
                    ID = 2,
                    login = "Artur"
                },
                new User {
                    ID = 3,
                    login = "Daniel"
                },
                new User {
                    ID = 4,
                    login = "Banan"
                },
            };

            return users;
        }

        private static List<Score> GetScores() {
            var scores = new List<Score>{
               new Score {
                   ID = 1,
                   userID =1,
                   scoreValue = 1100
               },
               new Score {
                   ID = 2,
                   userID =2,
                   scoreValue = 11
               },
               new Score {
                   ID = 3,
                   userID =3,
                   scoreValue = 22
               },
               new Score {
                   ID = 4,
                   userID =4,
                   scoreValue = 123
               },
                new Score {
                   ID = 5,
                   userID =4,
                   scoreValue = 0
               }
            };

            return scores;
        }

    }
}