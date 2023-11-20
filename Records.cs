namespace DR_records
{
    public class Records
    {
        public int id {  get; set; }
        public string title {  get; set; }
        public string artist { get; set; }
        public int duration { get; set; }
        public int publicationYear { get; set; }

        override public string ToString()
        {
            return $"id: {id}, title: {title}, artist: {artist}, duration: {duration}, publicationYear: {publicationYear}";
        }

        public void ValidateTitle()
        {
            if (title == null || title.Length == 0)
            {
                throw new ArgumentException("Title cannot be empty");
            }
        }   

        public void ValidateArtist()
        {
            if (artist == null || artist.Length == 0)
            {
                throw new ArgumentNullException("Artist cannot be empty");
            }
        }

        public void ValidateDuration()
        {
            if (duration <= 0)
            {
                throw new ArgumentOutOfRangeException("Duration must be greater than 0");
            }
        }

        public void ValidatePublicationYear()
        {
            if (publicationYear <= 1800)
            {
                throw new ArgumentOutOfRangeException("Publication year must be greater than 1800");
            }
        }

        public void ValidateAll()
        {
            ValidateTitle();
            ValidateArtist();
            ValidateDuration();
            ValidatePublicationYear();
        }
    }

}
