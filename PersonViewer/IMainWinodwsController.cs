namespace PersonViewer
{
    using System.Windows.Forms;
    interface IMainWinodwsController
    {
        void Add();
        void Update(ListViewItem lvi);
        void Delete(ListViewItem lvi);
        void Search(ToolStripTextBox txt);
    }
}
