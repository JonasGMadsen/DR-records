namespace DR_records
{
    public class RecordsRepository
    {
        private List<Records> _records;
        private int _nextId;
        
        public RecordsRepository()
        {
            _nextId = 1;
            _records = new List<Records>()
            {
                new Records() {id = _nextId++, title = "Wish you were here", artist = "Pink Floyd", duration = 50, publicationYear = 1997 }
            };
        }

        public List<Records> GetRecords()
        {
            return new List<Records>(_records);
        }
    }
}

