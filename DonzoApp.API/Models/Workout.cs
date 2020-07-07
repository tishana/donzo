using System;

namespace DonzoApp.API.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime DateCompleted { get; set; }
        public WorkoutType WorkoutType { get; set; }
        public int WorkoutTypeId { get; set; }
        public int Duration { get; set; }
        public Mood Mood { get; set; }
        public int MoodId { get; set; }

    }
}