namespace PersonController
{
    using DBIOLib;
    using PersonInfo;
    using System.Collections.Generic;

    public class PersonSearcher : IPersonSearcher
    {
        private readonly IDBDS _ds;
        public PersonSearcher(IDBDS ds)
        {
            this._ds = ds;
        }

        public bool SearchByNumber(uint number, out List<PersonInfo> results)
        {
            bool res = false;
            results = null;
            return res;
        }

        public bool SearchByName(string name, out List<PersonInfo> results)
        {
            bool res = false;
            results = null;
            return res;
        }

        public bool SearchByPhone(string name, out List<PersonInfo> results)
        {
            bool res = false;
            results = null;
            return res;
        }
    }
}
