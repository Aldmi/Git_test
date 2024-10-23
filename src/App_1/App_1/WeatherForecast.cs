namespace App_1;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public string? MainStatus { get; set; }

    public string? Status { get; set; }
    
    public byte[]? HashCode { get; set; }

     public string? TypeName { get; set; }
}
