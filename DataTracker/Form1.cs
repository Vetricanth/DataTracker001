using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace DataTracker
{
    public partial class Form1 : Form
    {
        String saveFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataTracker.yiff";
        string allText;
        DataGridView empty = new DataGridView();
        

        public Form1()
        {
            Initload();
            InitializeComponent();
            empty = dgv;
            this.Text = "Keepin the data for " + Environment.UserName;
        }

        public void Initload()
        {
            INITLOADD:
            try
            {
                allText = File.ReadAllText(saveFile);
            }
            catch (Exception)
            {
                MessageBox.Show("Failure to open the DataTracker.yiff File, attempting to create it." + Environment.NewLine + "Check the update info every update!");
                try
                {
                    if (!File.Exists(saveFile))
                    {
                        File.WriteAllText(saveFile, Environment.UserName + "|");
                    }
                    goto INITLOADD;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void SaveTextFile()
        {
            string user = Environment.UserName;
            string fullDataGridView;
            List<string> rows = new List<string>();
            List<string> cells = new List<string>();
            for (int x = 0; x < dgv.RowCount; x++)
            {
                for (int y = 0; y < dgv.Rows[x].Cells.Count; y++)
                {
                    if (!(dgv.Rows[x].Cells[y].Value == null)) { cells.Add(dgv.Rows[x].Cells[y].Value.ToString()); }
                    else { cells.Add(""); }
                }
                rows.Add(string.Join("}", cells));
                cells = new List<string>();
            }

            fullDataGridView = string.Join("`", rows);
            allText = Environment.UserName + "|" + fullDataGridView;
            File.WriteAllText(saveFile, allText);
        }

        public void DigestTextFile(string foodFile)
        {
            string[] mainSections = foodFile.Split('|');
            string[] rows = mainSections[1].Split('`');
            for (int i = 0; i < rows.Length; i++)
            {
                string[] cells = rows[i].Split('}');
                this.dgv.Rows.Add(cells);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DigestTextFile(allText);
            updateTimer.Enabled = true;
            if (Properties.Settings.Default.CheckHourly)
            {
                isOnclickToToggleToolStripMenuItem.Text = "is on(click to toggle)";
            }
            else
            {
                isOnclickToToggleToolStripMenuItem.Text = "is off(click to toggle)";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTextFile();
            Properties.Settings.Default.Save();
        }

        private void addRow()
        {
            List<string> cellsa = new List<string>();
            cellsa.Add(nameBox.Text);
            cellsa.Add(cbType.Text);
            cellsa.Add(btnDetails.Text);
            cellsa.Add(cbCompletion.Text);
            cellsa.Add(dtpSubmittionDate.Text);
            cellsa.Add(cbImportance.Text);
            cellsa.Add(cbPercentPaid.Text);
            cellsa.Add(priceBox.Text);
            cellsa.Add(dtp.Text);
            string[] hur = cellsa.ToArray();
            this.dgv.Rows.Add(hur);
            clearInputs();
        }
        private void clearInputs()
        {
            nameBox.Text = "";
            cbImportance.SelectedItem = "low";
            cbPercentPaid.Text = "0.00";
            priceBox.Text = "0.00";
            cbType.SelectedItem = "Commission";
            cbCompletion.SelectedItem = "0%";
            btnDetails.Text = "Click me";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRow();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInputs();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            detailButton d = new detailButton(btnDetails);
            d.Show();
        }

        public void dONTSAVEReloadComissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initload();
            dgv.DataSource = null;
            DigestTextFile(allText);
        }
        public void sAVEFIRSTThenReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTextFile();
            dgv.DataSource = null;
            DigestTextFile(allText);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == detailColumn.Index)
            {
                detailButton d = new detailButton(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                d.Show();
            }
        }

        private void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstallUpdateSyncWithInfo();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckHourly)
            {
                InstallUpdateSyncWithInfo();
            }
        }

        private void isOnclickToToggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckHourly)
            {
                isOnclickToToggleToolStripMenuItem.Text = "is off(click to toggle)";
                Properties.Settings.Default.CheckHourly = false;
            }
            else
            {
                isOnclickToToggleToolStripMenuItem.Text = "is on(click to toggle)";
                Properties.Settings.Default.CheckHourly = true;
            }
        }

        private void buttonBUG_Click(object sender, EventArgs e)
        {
            string problem = box_BUG.Text;
        }
    }
}
