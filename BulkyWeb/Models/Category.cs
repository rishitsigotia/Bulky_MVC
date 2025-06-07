using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
	public class Category
	{
		[Key] //data annotation for primary key
        public int Id { get; set; } //Primary Key 
		[Required] 
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
    }
}
