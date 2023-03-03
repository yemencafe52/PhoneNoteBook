namespace PersonController
{
    using DBIOLib;
    using PersonInfo;
    public class PersonEditor : IPersonEditor
    {
        private readonly IDBDS _ds;
        public PersonEditor(IDBDS ds)
        {
            this._ds = ds;
        }

        public bool Edit(PersonInfo person)
        {
            bool res = false;
            return res;
        }
    }
}
