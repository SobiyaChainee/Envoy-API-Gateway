namespace WebApp1.Models
{
    public class todo_brand
    {
        public long Id { get; set; }
        public string? todo_Name { get; set; }
        public bool IsComplete { get; set; }

        public string? brand_Name { get; set; }

        public string? Category { get; set; }

        public int IsActive { get; set; }
    }
}
