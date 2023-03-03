namespace PersonInfo
{
    /// <summary>
    /// Person Struct
    /// </summary>
    public class PersonInfo
    {
        private uint number;
        private string name;
        private string phone;

        /// <summary>
        /// Person Construct
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        public PersonInfo(
         uint number,
         string name,
         string phone  
            )
        {
            this.number = number;
            this.name = name;
            this.phone = phone;
        }

        public uint Number
        {
            get
            {
                return this.number;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
        }
    }
}
