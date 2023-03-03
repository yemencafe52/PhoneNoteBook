using System.Windows.Forms;

namespace PersonViewer
{
    public interface IPeopleViewController
    {
        void Add(Form FPM);
        void Delete(ListView listView);
        void Search(in ToolStripTextBox txt, ListView listView);
        void Update(Form FPM);
    }
}