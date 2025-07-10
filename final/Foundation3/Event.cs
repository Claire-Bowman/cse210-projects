public class Event
    {
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;

        public Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address.GetFullAddress()}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDescription()
        {
            return $"Event Type: General\nTitle: {_title}\nDate: {_date}";
        }

        protected string Title => _title;
        protected string Description => _description;
        protected string Date => _date;
        protected string Time => _time;
        protected Address EventAddress => _address;
    }