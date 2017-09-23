using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RestSharp
{
    public class WHMCreateAccountModel
    {
        public string username { get; set; }
        public string domain { get; set; }
        public string plan { get; set; }
        public string pkgname { get; set; }
        public bool savepkg { get; set; } = false;
        public string featurelist { get; set; }
        public int quota { get; set; } = 0;
        public string password { get; set; }
        public string ip { get; set; } = "n";
        public bool cgi { get; set; } = true;
        public bool frontpage { get; set; }
        public bool hasshell { get; set; } = true;
        public string contactemail { get; set; }
        public string cpmod { get; set; }
        public string maxftp { get; set; } = "unlimited";
        public string maxsql { get; set; } = "unlimited";
        public string maxpop { get; set; } = "unlimited";
        public string maxlst { get; set; } = "unlimited";
        public string maxsub { get; set; } = "unlimited";
        public string maxpark { get; set; } = "0";
        public string maxaddon { get; set; } = "0";
        public string bwlimit { get; set; } = "unlimited";
        public string customip { get; set; }
        public string language { get; set; } = "en";
        public bool useregns { get; set; } = false;
        public bool hasuseregns { get; set; }
        public bool reseller { get; set; } = false;
        public bool forcedns { get; set; } = false;
        public string mailbox_format { get; set; }
        public string mxcheck { get; set; } = "local";
        public int max_email_per_hour { get; set; } = 0;
        public int max_defer_fail_percentage { get; set; } = 0;
        public int uid { get; set; }
        public int gid { get; set; }
        public string homedir { get; set; }
        public bool dkim { get; set; } = true;
        public bool spf { get; set; } = true;
        public string owner { get; set; }         
    }
}
