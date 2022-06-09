namespace MijnEersteWebApp.Models
{
    public class InfoViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public int Age { get; set; }

        //public bool Adult { get { return Age >= 18; } }
        public bool Adult => Age >= 18;
    }
}