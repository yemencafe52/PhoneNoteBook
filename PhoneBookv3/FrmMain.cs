namespace PhoneBookv3
{
    using DBIOLib;
    using PersonController;
    using PersonViewer;
    using System.Windows.Forms;
    public partial class FrmMain : Form
    {
        private readonly IPeopleViewController _PVC;
        public FrmMain(IPeopleViewController _PVC)
        {
            InitializeComponent();
            this._PVC = _PVC;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            this._PVC.Add(new FrmPersonMgr(new PersonGenerator(new PersonWriter(new DBDS(Constants.ConnectionString)))));
            toolStripButton4.PerformClick();
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {   
            this._PVC.Add(new FrmPersonMgr(new PersonInfo.PersonInfo(1,"Person1","123456789"), new PersonViewEditor(new PersonController.PersonEditor(new DBDS(Constants.ConnectionString)))));
            toolStripButton4.PerformClick();
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {   
            this._PVC.Delete(this.listView1);
            toolStripButton4.PerformClick();
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            this._PVC.Search(this.toolStripTextBox1, this.listView1);
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmAbout FA = new FrmAbout();
            FA.ShowDialog();
        }

        private void FrmMain_Shown(object sender, System.EventArgs e)
        {
            toolStripTextBox1.Focus();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to close this app?", "Phone NoteBook v3", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if(res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                toolStripButton4.PerformClick();
            }
        }
    }
}
