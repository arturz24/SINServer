using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SINServer.Models {
    public class User {
        public int ID { get; set; }
        public string login { get; set; }
        public List<Score> userScorces { get; set; }
    }
}