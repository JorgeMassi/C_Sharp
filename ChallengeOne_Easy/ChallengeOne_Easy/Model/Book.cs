namespace ChallengeOne_Easy.Model
{
   
    internal class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string isbn { get; set; }

        
        override
        public string ToString()
        {
            
            return "ID:\t" + id + "\tTitle:\t" + title + "\tDescription:\t" + description + "\tISBN:\t" + isbn;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
