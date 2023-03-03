namespace PersonController
{
    public interface IPersonReader
    {
        bool Read(uint number, out PersonInfo.PersonInfo person);
    }
}