namespace addObjectThrowAntherTable.Models
{
    public class student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public List<session> sessions { get; set; }

    }
}
