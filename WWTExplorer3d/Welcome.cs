using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TerraViewer
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            SetUiStrings();
        }

        private void SetUiStrings()
        {

            this.label1.Text = "Welcome to Multiverse";// Language.GetLocalizedText(488, );

            this.richTextBox1.Text = "Navigating in Multiverse: \n\n    \u25CF Move around the sky by clicking and dragging the Field of View. \n    \u25CF Zoom in/out by scrolling the mouse wheel, pressing -/+ or Page Up/Page Down. \n    \u25CF Drag with center mouse button or hold Ctrl while dragging to rotate and tilt view.\n    \u25CF Navigate with a XBOX 360 controller by connteting it before launching.\n    \u25CF Click an object’s thumbnail to pan to the object. Double-clicking the object’s\n        thumbnail jumps you to the object. \n    \u25CF Page through multiple thumbnail panes with the scroll wheel \n    \u25CF Right-click an object to display the contextual Finder Scope for more information. \n    \u25CF Menu Tabs have two parts: click the tab’s top to open a pane,\n        click the tab’s bottom to open submenus with additional functionality. ";//Language.GetLocalizedText(487, );
            this.close.Text = Language.GetLocalizedText(212, "Close");
            this.dontShowAgain.Text = Language.GetLocalizedText(489, "Do not show me this dialog again");


        }

        private void close_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowNavHelp = !dontShowAgain.Checked;
            DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This causes the welcome screen to go away if anther instance sends us data
            if (Earth3d.MainWindow.CloseWelcome)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}