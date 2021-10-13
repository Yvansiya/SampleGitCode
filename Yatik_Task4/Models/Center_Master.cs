using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yatik_Task4.Models
{
    public class Center_Master
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    [StringLength(20)]
    public string CenterName { get; set; }
    //public string CenterType { get; set; }
     public int SortOrder { get; set; }
    public bool IsActive { get; set; }
    }
}