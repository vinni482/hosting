using Models.RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace Hosting.Controllers
{
    public class ApiTestController : ApiController
    {
        [HttpGet]
        
        public WHMCreateAccountResponseModel Index([FromUri]WHMCreateAccountModel model)
        {
            return new WHMCreateAccountResponseModel
            {
                result = new List<Result>()
                {
                    new Result
                    {
                        options = new Options
                        {
                            nameserverentry3 = null,
                            nameservera = null,
                            nameserver4 = "",
                            ip = "192.168.0.1",
                            nameservera4 = null,
                            nameserver = "ns1.example-host.com",
                            package = "package_name",
                            nameserver2 = "ns2.example-host.com",
                            nameservera2 = null,
                            nameserverentry4 = null,
                            nameservera3 = null,
                            nameserverentry2 = null,
                            nameserverentry = null,
                            nameserver3 = ""
                        },
                        rawout = "<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Checking input data......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Validating system setup......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Rebuilding IP Pool...System has 0 free ips.\n...Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Validating IP......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Validating Username......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Validating Contact Email......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Checking for database conflicts......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>WWWAcct 12.6.0 (c) 2014 cPanel, Inc....\n\nForced Dns is enabled.\n+===================================+\n| New Account Info                  |\n+===================================+\n| Domain: example.com\n| Ip: 192.168.0.1 (n)\n| HasCgi: y\n| UserName: user\n| PassWord: 12345luggage\n| CpanelMod: paper_lantern\n| HomeRoot: /home\n| Quota: 0 Meg\n| NameServer1: ns1.example-host.com\n| NameServer2: ns2.example-host.com\n| NameServer3: \n| NameServer4: \n| Contact Email: user@seconddomain.com\n| Package: package_name\n| Feature List: default\n| Language: en\n+===================================+\n...Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Running pre creation script (/usr/local/cpanel/scripts/prewwwacct)......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Adding User...Adding Shell Access (y)\nSuccess...Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Adding Entries to userdata......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Updating the userdata cache......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Setting up Mail & Local Domains...localdomains...valiases ...vdomainaliases...vfilters......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Configuring DNS...Bind reconfiguring on sarah using rndc\nZone example.com has been successfully added\n...Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Updating Authentication Databases......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Adding Entries to httpd.conf......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Restarting apache......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Setting passwords...Password for 'user' has been changed.\nUpdating FTP passwords for user\nFTP password files updated.\nFTP vhost passwords synced\n...Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Updating the dedicated IP address usage cache......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Verifying MX Records and Setting up Databases...Reconfiguring Mail Routing:\n<ul><li>LOCAL MAIL EXCHANGER: This server will serve as a primary mail exchanger for example.com's mail.:<br /> This configuration has been manually selected.<br /><br /></li></ul>...Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Setting up Proxy Subdomains......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\nBind reloading on sarah using rndc zone: [example.com]\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Sending Account Information......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\nSystem has 0 free ips.\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Running post creation scripts (/usr/local/cpanel/scripts/legacypostwwwacct, /usr/local/cpanel/scripts/postwwwacct, /usr/local/cpanel/scripts/postwwwacctuser)......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\nwwwacct creation finished\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Setting up Domain Pointers......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Setting Reseller Privs......Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n<table style=\"border-bottom: 1px #ccc dotted;\"><tr><td width=\"100%\"><pre>Account Creation Complete!!!...Account Creation Ok...Done</pre></td><td width=\"30\"><img align=absmiddle src=\"/cPanel_magic_revision_1370377684/cjt/images/icons/success.png\"></td></tr></table>\n",
                        status = 1,
                        statusmsg = "Account Creation Ok"
                    }
                }
            };
        }


    }
}
