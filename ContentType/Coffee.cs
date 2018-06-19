using System;
using System.Runtime.Serialization;

namespace ContentType
{
    [DataContract]
    public class Coffee
    {
        [DataMember(Name = "Id", IsRequired = false, Order = 0)]
        private long _id;

        [DataMember(Name = "Name", IsRequired = true, Order = 1)]
        private string _name;

        [DataMember(Name = "Description", IsRequired = true, Order = 2)]
        private string _description;

        [DataMember(Name = "Date", IsRequired = true, Order = 3)]
        private DateTime _date;

        [DataMember(Name = "Url", IsRequired = false, Order = 5)]
        private string _url;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
