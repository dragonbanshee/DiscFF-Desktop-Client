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
        /// <summary>
        /// TF2 "Connect" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string server = SplitBracket(selectedItem);
            if(server == "Minigames [74.91.113.50:27037]")
            {
                MessageBox.Show("You must select a TF2 server!", "Error");
            }
            else
            {
                Process.Start(STEAM_CONNECT + server);
            }
        }

        /// <summary>
        /// CSGO "Connect" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string server = SplitBracket(selectedItem);
            if (server != "Minigames [74.91.113.50:27037]")
            {
                MessageBox.Show("You must select a CSGO server!", "Error");
            }
            else
            {
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
            return toSplit.Split('[')[1].Split(']')[0];
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
                tf2OtherListBox,
                csgoOtherListBox
            };
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

        private void csgoOtherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (csgoOtherListBox.SelectedIndex >= 0)
            {
                selectedItem = csgoOtherListBox.Items[csgoOtherListBox.SelectedIndex].ToString();
                DeselectServers(csgoOtherListBox);
            }
        }

        #endregion
    }
}
