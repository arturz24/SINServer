using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SINServer.Models {
    public class Score {
        public int ID { get; set; }
        public int scoreValue { get; set; }

        public int userID { get; set;}
    }
}