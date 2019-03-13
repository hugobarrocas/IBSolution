using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBSolution.Graph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

    

        

        private void SourcesButton_Click(object sender, EventArgs e)
        {
            if(SelectSourcesDir.ShowDialog() == DialogResult.OK) {

                SourcesPathBox.Text = Path.GetDirectoryName(SelectSourcesDir.FileName);
                IBSolution.Program.SourceFilesDir = SourcesPathBox.Text;
            }
        }

        private void SnifFilePath_Click(object sender, EventArgs e)
        {
            if(SelectLineDetailsDialog.ShowDialog() == DialogResult.OK)
            {
                LineDetailsPath.Text = SelectLineDetailsDialog.FileName;
                IBSolution.Program.SniffileToWork = LineDetailsPath.Text;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            IBSolution.Program.filepath = Path.GetDirectoryName(SelectLineDetailsDialog.FileName) +"\\"+ TargetFileBox.Text;
            //IBSolution.Program.SniffileToWork = LineDetailsPath.Text;
            //IBSolution.Program.SourceFilesDir = SourcesPathBox.Text;
            this.Close();
        }

        private void SelectSourcesDir_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Guidelinestextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
