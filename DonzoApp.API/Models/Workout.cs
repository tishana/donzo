namespace DonzoApp.API.Models
{
    public class Workout
    {
        public int Id { get; set; }
        //public date Date { get; set; }
        public int WTypeId { get; set; }
        public int Duration { get; set; }
        public int MoodId { get; set; }
        public int UserId { get; set; }

    }
}