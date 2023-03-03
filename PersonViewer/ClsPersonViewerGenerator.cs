namespace PersonViewer
{
    using PersonController;
    using PersonInfo;
    using System.Windows.Forms;

    /// <summary>
    /// Person Generator Class
    /// </summary>
    public class PersonGenerator : IPersonMgrController
    {
        private readonly IPersonWriter _personWriter;
        public PersonGenerator(IPersonWriter _personWriter)
        {
            this._personWriter = _personWriter;
        }

        /// <summary>
        /// Save New PersonInfo In DataBase
        /// </summary>
        /// <param name="nudNumber">Person Number NumricUpDown Control</param>
        /// <param name="txtName">Person Name TextBox Control</param>
        /// <param name="txtPhone">Person Phone TextBox Control</param>
        /// <returns>True If Success Else False</returns>
        public bool Save(NumericUpDown nNumber, TextBox txtName, TextBox txtPhone)
        {
            bool res;

            if (_personWriter.Write(new PersonInfo((uint)nNumber.Value, txtName.Text, txtPhone.Text)))
            {
                res = true;
                MessageBox.Show("Person has been added successfully.");
            }
            else
            {
                res = false;
                MessageBox.Show("OOPS, SOMETHING WENT WRONG :(");
            }

            return res;
        }
    }
}
