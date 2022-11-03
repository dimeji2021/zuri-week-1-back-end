using System.ComponentModel.DataAnnotations;

namespace zuri_week_1
{
    public class InputDto
    {
        [Required]
        public int x { get; set; }
        [Required]
        public int y { get; set; }
        [Required]
        public OperationType operation_type { get; set; }
    }
}