using System;

namespace DonzoApp.API.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime DateCompleted { get; set; }
        public WorkoutType WTypeId { get; set; }
        public int Duration { get; set; }
        public Mood MoodId { get; set; }
        public User UserId { get; set; }

    }
}