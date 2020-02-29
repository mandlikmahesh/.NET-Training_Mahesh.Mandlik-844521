using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRMProjectCode.Models
{
    public class Requestdata
    {

        public string skill { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public int Exicutiveid { get; set; }
        public int Trainerid { get; set; }
        public string Requestname { get; set; }
        public int pmid { get; set; }
        public string status { get; set; }
        public int reqid { get; set; }
        public string PMName { get; set; }
    }
}
