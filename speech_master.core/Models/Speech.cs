namespace speech_master.core.Models
{
    public class Speech
    {
        public Guid SpeechId { get; set; }
        public string Sentence { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Feedback Feedback { get; set; }
    }
}
