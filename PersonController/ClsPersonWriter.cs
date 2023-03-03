namespace PersonController
{
    using DBIOLib;
    using PersonInfo;
    public class PersonWriter : IPersonWriter
    {
        private readonly IDBDS _ds;
        public PersonWriter(IDBDS ds)
        {
            this._ds = ds;
        }

        public bool Write(PersonInfo person)
        {
            bool res = false;
            return res;
        }
    }
}
