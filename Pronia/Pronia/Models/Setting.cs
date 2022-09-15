namespace Pronia.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsDisabled { get; set; }=false;




    }
}
