namespace TestApi.Models
{
    public class Conference
    {
        public string guid {set; get;}

        public string title {set; get;}

        public string abbreviation {set; get;}

        public DateTime beginning {set; get;}

        public DateTime ending {set; get;}

        public Lecture[] lectures {set; get;}
    }
}