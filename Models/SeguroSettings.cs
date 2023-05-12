namespace ApiPolizas.Models
{
    public class SeguroSettings : ISeguroSettings
    {
        public string? Server { get; set; }
            
        public string? Database { get; set; }

        public string?  Collection { get; set; }
                          
    }

    public interface ISeguroSettings
    {
        string? Server { get; set; }    
        string? Database { get; set; }
        string? Collection { get; set; }

    }
}
