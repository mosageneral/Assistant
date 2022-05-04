using System.ComponentModel;

namespace AssistantApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [DisplayName("وصف الموعد")]
        public string Discribtion { get; set; }
        [DisplayName("تاريخ الموعد")]
        [DateLessThanOrEqualToToday]
        public DateTime Date { get; set; }
        [DisplayName("انتهاء الموعد ؟")]

        public bool IsDone { get; set; } = false;

    }
}
