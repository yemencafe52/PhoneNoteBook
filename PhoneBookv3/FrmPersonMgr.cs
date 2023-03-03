namespace PhoneBookv3
{
    using PersonInfo;
    using PersonViewer;
    using System;
    using System.Windows.Forms;

    public partial class FrmPersonMgr : Form
    {
        private readonly IPersonMgrController _PC;
        private readonly PersonInfo person;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        public FrmPersonMgr(IPersonMgrController _PC)
        {
            InitializeComponent();
            this._PC = _PC;
        }

        public FrmPersonMgr(PersonInfo person,IPersonMgrController _PC)
        {
            InitializeComponent();
            this.person = person;
            this._PC = _PC;

            this.numericUpDown1.Value = this.person.Number;
            this.numericUpDown1.Enabled = false;

            this.textBox1.Text = this.person.Name;
            this.textBox2.Text = this.person.Phone;      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._PC.Save(numericUpDown1, textBox1, textBox2);
        }
    }
}
