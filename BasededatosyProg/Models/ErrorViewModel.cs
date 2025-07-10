namespace BasededatosyProg.Models;
using Newtonsoft.Json;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
