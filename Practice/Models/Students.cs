namespace Practice.Models
{
    public class Students
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Age { get; set; }
        public required DateTime DOB { get; set; }
        public  required string  Classes { get; set; }
    }
}
