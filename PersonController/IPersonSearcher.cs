namespace PersonController
{
    using System.Collections.Generic;
    public interface IPersonSearcher
    {
        bool SearchByName(string name, out List<PersonInfo.PersonInfo> results);
        bool SearchByNumber(uint number, out List<PersonInfo.PersonInfo> results);
        bool SearchByPhone(string name, out List<PersonInfo.PersonInfo> results);
    }
}