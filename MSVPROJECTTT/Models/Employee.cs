using System.ComponentModel.DataAnnotations;
namespace emp;

public class Employee
{
    [Required]
    public int eid { get; set; }

    [Required]
    public String ename { get; set; }
    [Required]
    public String edept {get;set;}

    public Employee()
    {
        
    }
    public Employee(int eid,String ename,String edept)
    {
        this.eid=eid;
        this.ename=ename;
        this.edept=edept;
    }
}
