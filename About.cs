using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unzipper
{
    public partial class About : Form
    {
        //Get location Unzipper was launched from
        private string unzipperLocation = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        //Create array of supported filetypes. Windows 10 uses 'CompressedFolder' instead of '.zip'.
        string[] fileTypes = { "CompressedFolder", ".7z", ".rar", ".zipx", ".tar", ".gz" };

        public About()
        {
            InitializeComponent();
        }

        //Adds 'Open with Unzipper' Context Menu item
        private void addContextMenuButton_Click(object sender, EventArgs e)
        {
            //Set the registry values for adding Unzipper to the File Explorer Context Menu
            //This is done under HKCU as it doesn't require local admin permissions to add the item
            foreach (string regFileTypeEntry in fileTypes)
            {
                string contextMenuRegistryLocation = "HKEY_CURRENT_USER\\SOFTWARE\\Classes\\" + regFileTypeEntry + "\\shell\\Open with Unzipper";
                string contextMenuCommandLocation = contextMenuRegistryLocation + @"\\command";
                string contextMenuIconString = unzipperLocation + @"\Unzipper.ico";
                string contextMenuCommandString = unzipperLocation + @"\Unzipper.exe ""%1""";
                //Icon and executable
                Registry.SetValue(contextMenuRegistryLocation, "Icon", contextMenuIconString);
                Registry.SetValue(contextMenuCommandLocation, "", contextMenuCommandString);
            }
            MessageBox.Show("Done!");
        }

        //Removes 'Open with Unzipper' Context Menu item
        private void removeContextMenuButton_Click(object sender, EventArgs e)
        {
            //Remove the 'Open with Unzipper' Context Menu item for each supported file type, leaving any other CM items for those file types that have been created
            foreach (string regFileTypeEntry in fileTypes)
            {
                string contextMenuRegistryLocation = "SOFTWARE\\Classes\\" + regFileTypeEntry + "\\shell\\Open with Unzipper";
                Registry.CurrentUser.DeleteSubKeyTree(contextMenuRegistryLocation,false);
            }
            MessageBox.Show("Done!");
        }
    }
}
