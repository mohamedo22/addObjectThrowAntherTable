using addObjectThrowAntherTable.Models;

namespace addObjectThrowAntherTable.DTOs
{
    public class sessionDTO
    {
        public string sessionName { get; set; }
        public List<studentDTO> students { get; set; }
    }
}
