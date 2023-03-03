namespace PersonViewer
{
    using PersonController;
    using PersonInfo;
    using System.Windows.Forms;

   /// <summary>
   /// Person Editor Class
   /// </summary>
    public class PersonViewEditor : IPersonMgrController
    {
        private readonly IPersonEditor _personEditor;
        public PersonViewEditor(IPersonEditor _personEditor)
        {
            this._personEditor = _personEditor;
        }

        /// <summary>
        /// Update Person Info In DataBase
        /// </summary>
        /// <param name="nudNumber">Person Number NumricUpDown Control</param>
        /// <param name="txtName">Person Name TextBox Control</param>
        /// <param name="txtPhone">Person Phone TextBox Control</param>
        /// <returns>True If Success Else False</returns>
        public bool Save(NumericUpDown nudNumber, TextBox txtName, TextBox txtPhone)
        {
            bool res;

            if (_personEditor.Edit(new PersonInfo((uint)nudNumber.Value, txtName.Text, txtPhone.Text)))
            {
                res = true;
                MessageBox.Show("Person has been updated successfully.");
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
