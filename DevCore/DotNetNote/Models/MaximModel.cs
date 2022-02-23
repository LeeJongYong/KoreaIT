using System.ComponentModel.DataAnnotations;

namespace DotNetNote.Models
{
    public class MaximModel
    {
        public int Id { get; set; }
        [Display(Name = "이름")]
        [Required(ErrorMessage = "이름을 입력하세요")]
        public string Name { get; set; }
        [Display(Name = "내용")]
        [Required(ErrorMessage = "내용을 입력하세요")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "내용은 1 ~ 255자 사이")]
        public string Content { get; set; }
    }
}
