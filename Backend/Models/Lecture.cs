namespace TestApi.Models
{
    public class Lecture
    {
        public string guid {set; get;}

        public string title {set; get;}

        public Lecturer lecturer {set; get;}

        public DateTime beginning {set; get;}

        public DateTime ending {set; get;}

        public Review[] reviews {set; get;}
    }
}