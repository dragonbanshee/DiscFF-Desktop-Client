using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

using SSQLib;

namespace DiscFFClient
{
    class GameTracker
    {
        public static GameTrackerResponse GetText(string _ip)
        {
            string[] split = _ip.Split(':');
            string ip = split[0];
            string port = split[1];

            SSQL sq = new SSQL();
            ServerInfo si = sq.Server(ip, Convert.ToInt32(port));
            return new GameTrackerResponse
            {
                name = si.Name,
                ip = _ip,
                players = si.PlayerCount,
                playersmax = si.MaxPlayers,
                map = si.Map
            };
        }

    }

    class GameTrackerResponse
    {
        public string name { get; set; }
        public string ip { get; set; }
        public string players { get; set; }
        public string playersmax { get; set; }
        public string map { get; set; }
    }
}
