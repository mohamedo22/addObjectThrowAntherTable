namespace addObjectThrowAntherTable.Models
{
    public class session
    {
        public int sessionId { get; set; }
        public string sessionName { get; set; }
        public List<student> students { get; set; }
    }
}
