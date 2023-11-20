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
                new Records() {id = _nextId++, title = "Wish you were here", artist = "Pink Floyd", duration = 50, publicationYear = 1977 },
                new Records() {id = _nextId++, title = "The Wall", artist = "Pink Floyd", duration = 80, publicationYear = 1979 },
                new Records() {id = _nextId++, title = "The Dark Side of the Moon", artist = "Pink Floyd", duration = 42, publicationYear = 1973 }
            };
        }

        public List<Records> Get()
        {
            return new List<Records>(_records);
        }

        public Records? GetById(int id)
        {
            return _records.Find(r => r.id == id);
        }

        public Records Add(Records record)
        {
            record.id = _nextId++;
            _records.Add(record);
            return record;
        }
    }
}

