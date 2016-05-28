using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DiscFFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ListBox> serverBoxes;
        private string selectedItem;
        private const string STEAM_CONNECT = "steam://connect/";

        public const string FF1 = "74.91.119.154:27016";
        public const string FF2 = "74.91.119.154:27019";
        public const string FF3 = "74.91.113.65:27017";

        public const string TF1 = "216.52.148.85:27015";
        public const string TF2 = "74.91.113.50:27066";

        public const string IT1 = "74.91.119.154:27015";
        public const string IT2 = "74.91.119.154:27017";
        public const string IT3 = "74.91.113.65:27019";

        public const string RANDOMIZER = "74.91.119.154:27029";
        public const string X10 = "74.91.113.50:27049";

        public const string VSH1 = "74.91.113.65:27015";
        public const string VSH2 = "74.91.113.50:27077";

        public const string SF1 = "74.91.113.50:27019";
        public const string SF2 = "74.91.113.50:27091";

        public const string DR = "74.91.119.154:27014";
        public const string PH = "74.91.113.50:27016";
        public const string DB = "162.248.92.127:27021";
        public const string SURF = "74.91.113.50:27032";
        public const string PL = "74.91.113.50:27030";

        public List<string> servers = new List<string>()
        {
            FF1,
            FF2,
            FF3,
            TF1,
            TF2,
            IT1,
            IT2,
            IT3,
            RANDOMIZER,
            X10,
            VSH1,
            VSH2,
            SF1,
            SF2,
            DR,
            PH,
            DB,
            SURF,
            PL
        };

        /// <summary>
        /// TF2 "Connect" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(selectedItem == null)
            {
                MessageBox.Show("You must select a TF2 server!", "Error");
            }
            else
            {
                string server = SplitBracket(selectedItem);
                Process.Start(STEAM_CONNECT + server);
            }
        }

        /// <summary>
        /// Returns the string inside two brackets "[]"
        /// </summary>
        /// <param name="toSplit">The string to search and split</param>
        /// <returns></returns>
        private string SplitBracket(string toSplit)
        {
            Regex re = new Regex(@"(\[\d+\.\d+\.\d+\.\d+\:\d+\])");
            Match match = re.Match(toSplit);
            if (match.Success)
            {
                int index = match.Index;
                int length = match.Length;
                return toSplit.Substring(index + 1, length - 2);
            }
            else
            {
                return toSplit.Split('[')[1].Split(']')[0];
            }
        }

        /// <summary>
        /// Deselects all selections from all server listboxes
        /// </summary>
        /// <param name="exceptThisOne">The box to exclude</param>
        private void DeselectServers(ListBox exceptThisOne)
        {
            foreach (ListBox box in serverBoxes)
            {
                if (box == exceptThisOne) continue;
                else box.ClearSelected();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverBoxes = new List<ListBox>()
            {
                ffListBox,
                idleListBox,
                mkListBox,
                slenderListBox,
                tradeListBox,
                vshListBox,
                tf2OtherListBox
            };
            Refresh();
        }

        #region event handlers
   
        private void ffListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ffListBox.SelectedIndex >= 0)
            {
                selectedItem = ffListBox.Items[ffListBox.SelectedIndex].ToString();
                DeselectServers(ffListBox);
            }
        }

        private void tradeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tradeListBox.SelectedIndex >= 0)
            {
                selectedItem = tradeListBox.Items[tradeListBox.SelectedIndex].ToString();
                DeselectServers(tradeListBox);
            }
        }

        private void idleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idleListBox.SelectedIndex >= 0)
            {
                selectedItem = idleListBox.Items[idleListBox.SelectedIndex].ToString();
                DeselectServers(idleListBox);
            }
        }

        private void mkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mkListBox.SelectedIndex >= 0)
            {
                selectedItem = mkListBox.Items[mkListBox.SelectedIndex].ToString();
                DeselectServers(mkListBox);
            }
        }

        private void vshListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vshListBox.SelectedIndex >= 0)
            {
                selectedItem = vshListBox.Items[vshListBox.SelectedIndex].ToString();
                DeselectServers(vshListBox);
            }
        }

        private void slenderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (slenderListBox.SelectedIndex >= 0)
            {
                selectedItem = slenderListBox.Items[slenderListBox.SelectedIndex].ToString();
                DeselectServers(slenderListBox);
            }
        }

        private void tf2OtherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tf2OtherListBox.SelectedIndex >= 0)
            {
                selectedItem = tf2OtherListBox.Items[tf2OtherListBox.SelectedIndex].ToString();
                DeselectServers(tf2OtherListBox);
            }
        }

        #endregion

        private void button3_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }

        private new void Refresh()
        {
            for (int i = 0; i < ffListBox.Items.Count; i++)
            {
                GameTrackerResponse gtr = GameTracker.GetText(SplitBracket((string)ffListBox.Items[i]));
                ffListBox.Items[i] = string.Format("{0} [{1}] - {2} ({3}/{4})", gtr.name, servers[i], gtr.map, gtr.players, gtr.playersmax);
            }
            for (int i = 0; i < tradeListBox.Items.Count; i++)
            {
                GameTrackerResponse gtr = GameTracker.GetText(SplitBracket((string)tradeListBox.Items[i]));
                tradeListBox.Items[i] = string.Format("{0} [{1}] - {2} ({3}/{4})", gtr.name, servers[i + 3], gtr.map, gtr.players, gtr.playersmax);
            }
            for (int i = 0; i < idleListBox.Items.Count; i++)
            {
                GameTrackerResponse gtr = GameTracker.GetText(SplitBracket((string)idleListBox.Items[i]));
                idleListBox.Items[i] = string.Format("{0} [{1}] - {2} ({3}/{4})", gtr.name, servers[i + 5], gtr.map, gtr.players, gtr.playersmax);
            }
            for (int i = 0; i < mkListBox.Items.Count; i++)
            {
                GameTrackerResponse gtr = GameTracker.GetText(SplitBracket((string)mkListBox.Items[i]));
                mkListBox.Items[i] = string.Format("{0} [{1}] - {2} ({3}/{4})", gtr.name, servers[i + 8], gtr.map, gtr.players, gtr.playersmax);
            }
            for (int i = 0; i < vshListBox.Items.Count; i++)
            {
                GameTrackerResponse gtr = GameTracker.GetText(SplitBracket((string)vshListBox.Items[i]));
                vshListBox.Items[i] = string.Format("{0} [{1}] - {2} ({3}/{4})", gtr.name, servers[i + 10], gtr.map, gtr.players, gtr.playersmax);
            }
            for (int i = 0; i < slenderListBox.Items.Count; i++)
            {
                GameTrackerResponse gtr = GameTracker.GetText(SplitBracket((string)slenderListBox.Items[i]));
                slenderListBox.Items[i] = string.Format("{0} [{1}] - {2} ({3}/{4})", gtr.name, servers[i + 12], gtr.map, gtr.players, gtr.playersmax);
            }
            for (int i = 0; i < tf2OtherListBox.Items.Count; i++)
            {
                GameTrackerResponse gtr = GameTracker.GetText(SplitBracket((string)tf2OtherListBox.Items[i]));
                tf2OtherListBox.Items[i] = string.Format("{0} [{1}] - {2} ({3}/{4})", gtr.name, servers[i + 14], gtr.map, gtr.players, gtr.playersmax);
            }
            DisableForTimeout();
        }

        private void DisableForTimeout()
        {
            int to = 1000 * 30;
            button3.Visible = false;
            Timer t = new Timer();
            t.Interval = to;
            t.Enabled = true;
            t.Start();
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            button3.Visible = true;
        }
    }
}
