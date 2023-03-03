namespace PersonController
{
    using DBIOLib;
    using PersonInfo;
    public class PersonReader : IPersonReader
    {
        private readonly IDBDS _ds;
        public PersonReader(IDBDS ds)
        {
            this._ds = ds;
        }

        public bool Read(uint number, out PersonInfo person)
        {
            bool res = false;
            person = null;
            return res;
        }
    }
}
