namespace TestApi.Models
{
    enum Rating
    {
        red,
        yellow,
        green
    }
    public class Review
    {
        public string guid { set; get; }

        public string reviewer { set; get; }

        public string email { set; get; }

        public Rating rating { set; get; }

        public DateTime votingTime { set; get; }

        public string comment { set; get; }
    }
}