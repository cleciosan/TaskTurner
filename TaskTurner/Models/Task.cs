using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTurner.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime StartDate { get; set; }

        public bool IsComplete { get; set; }

        public TimeSpan Timer { get; set; }

    }

    public enum TaskState
    {
        InProgress,
        Complete,
        NotStarted,
        Late,
        Archived,
        Deleted
    }

    public enum TaskCategory
    {
        /// <summary>
        /// Task rekated to your job, like meetings, project deadlines, or professional development activities.
        /// </summary>
        Work,

        /// <summary>
        /// Daily routines, hobbies, or personal goals
        /// </summary>
        Personal,

        /// <summary>
        /// Household chores, repairs, or home improvement projects.
        /// </summary>
        Home,
        
        /// <summary>
        /// Exercise routines, meal planning, doctor's appointments, or meditation.
        /// </summary>
        HealthWelbeing,
        
        /// <summary>
        /// Budgeting, bill payments, and financial planning.
        /// </summary>
        Finance,
        
        /// <summary>
        /// Grocery lists, clothing, or other shopping needs.
        /// </summary>
        Shopping,
        
        /// <summary>
        /// Family gatherings, social events, or activities with friends.
        /// </summary>
        SocialFamily,
        
        /// <summary>
        /// Study sessions, assignments, or educational goals.
        /// </summary>
        Education,
        
        /// <summary>
        /// Planning for trips, packing lists, or travel itineraries.
        /// </summary>
        Travel,

        /// <summary>
        /// Tasks like going to the post office, bank, or dry cleaners.
        /// </summary>
        Errands,

        /// <summary>
        /// Time set aside for hobbies or leisure activities.
        /// </summary>
        HobbiesLeisure,

        /// <summary>
        /// Community services or volunteering activities.
        /// </summary>
        VolunteeringCommunity,

        /// <summary>
        /// Special dates and celebrations.
        /// </summary>
        BirthdaysAnniversaries,

        /// <summary>
        /// Larger tasks that might span over multiple days or weeks.
        /// </summary>
        Projects,

        /// <summary>
        /// Objectives or goals that you're working towards over a longer period.
        /// </summary>
        LongTermGoals
    }
}
