namespace TaktikumTest.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string RequestMethod { get; set; }
        public string RequestUrl { get; set; } 
        public int ResponseStatusCode { get; set; }
        public DateTime RequestTime { get; set; }
    }
}
