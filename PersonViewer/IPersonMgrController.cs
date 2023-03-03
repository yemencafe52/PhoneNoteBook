using System.Windows.Forms;

namespace PersonViewer
{
    public interface IPersonMgrController
    {
        bool Save(NumericUpDown nudNumber, TextBox txtName, TextBox txtPhone);
    }
}