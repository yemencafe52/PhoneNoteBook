namespace PersonController
{
    public interface IPersonWriter
    {
        bool Write(PersonInfo.PersonInfo person);
    }
}