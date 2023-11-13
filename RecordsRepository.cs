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
                new Records() {id = _nextId++, title = "Wish you were here", artist = "Pink Floyd", duration = 50, publicationYear = 1977 }
            };
        }

        public List<Records> Get()
        {
            return new List<Records>(_records);
        }

        //public Records? GetById(int id)
        //{
        //    return _records.Find(r => r.id == id);
        //}

        //public Records Add(Records record)
        //{
        //    record.id = _nextId++;
        //    _records.Add(record);
        //    return record;
        //}
    }
}

