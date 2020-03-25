namespace WebApi.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public string AnswerContent { get; set; }
        public int UserId { get; set; }
    }
}