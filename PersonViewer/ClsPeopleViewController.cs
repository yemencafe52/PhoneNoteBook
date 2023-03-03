namespace PersonViewer
{
    using DBIOLib;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using PersonInfo;
    public class PeopleViewController : IPeopleViewController
    {
        private readonly IDBDS _db;

        public PeopleViewController(IDBDS _db)
        {
            this._db = _db;
        }

        public void Add(Form FPM)
        {
            FPM.ShowDialog();
        }
        public void Delete(ListView listView)
        {
        }

        public void Search(in ToolStripTextBox txt, ListView listView)
        {
            List<PersonInfo> res;
            listView.Items.Clear();

            if (new PersonController.PersonSearcher(this._db).SearchByName(txt.Text, out res))
            {
                List<ListViewItem> list = new List<ListViewItem>();

                for (int i = 0; i < res.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(res[i].Number.ToString());
                    lvi.SubItems.Add(res[i].Name);
                    lvi.SubItems.Add(res[i].Phone);
                }

                listView.Items.AddRange(list.ToArray());
            }
        }
        public void Update(Form FPM)
        {
            FPM.ShowDialog();
        }

    }
}
