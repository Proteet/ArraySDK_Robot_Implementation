using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Threading;
using System.IO;

using IntersonArray.Controls;
using IntersonArray.Imaging;

namespace SDK_Example
{
    /// <summary>
    /// Represents the probe form to choose one of the probe connected to the PC
    /// </summary>
    public partial class FormProbes : Form
    {
        public static StringCollection mycolProbesName = new StringCollection();
        FormProbes MyForm;
        int count = 0;
        public static int QUIT = -1;
        public static int CANCEL = -2;

        public FormProbes()
        {
            InitializeComponent();
            MyForm = this;
        }

        public int ShowProbes()
        {
            HWControls MyHwControls = new HWControls();
            try
            {
                // Enumerate all the probes that are connected to the PC
                MyHwControls.FindAllProbes(ref mycolProbesName);

                // Get the number of Probes
                count = mycolProbesName.Count;

                if (count == 0)
                {
                    lBoxMessage.Items.Add("Error: No Probe found.");
                }
                
                // Print out a list of the devices if there are at least 1.
                if (count >= 1)
                {
                    lBoxMessage.Items.Add("Found at least 1 probe, found: " + count.ToString() + " probe(s)");
                }

                for (int i = 0; i < mycolProbesName.Count; i++)
                {
                    cboxBoxProbes.Items.Add(mycolProbesName[i]);
                    cboxBoxProbes.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.ShowDialog();
            return count;

        }

        private void buttonCancel_Click(object sender, EventArgs e)//Idle
        {
            formScan2D.MyFormScan2D.labelProbeName.Text = "No probe selected";
            count = CANCEL;
            Close();
        }

        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            if (cboxBoxProbes.SelectedIndex >= 0)
            {
                // Initialize the USB interface with the selected probe
                HWControls MyHwControls = new HWControls();
                MyHwControls.FindMyProbe(cboxBoxProbes.SelectedIndex);
                // Get the probe's characteristics and initialize labelProbeName
                formScan2D.MyFormScan2D.labelProbeName.Text = mycolProbesName[cboxBoxProbes.SelectedIndex];
            }
            else
            {
                count = QUIT;
            }
            Close();

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            count = QUIT;
            Close();
        }

    }
}
