using System.ComponentModel.DataAnnotations;

namespace MyToDo.Model
{
    public class Todo
    {
        [ScaffoldColumn(false)]
        public int TodoId { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
