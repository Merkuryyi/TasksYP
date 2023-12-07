using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Вывести по умолчанию введите 1, чтобы выбрать город введите 0");
        string sity = "";
        int func = int.Parse(Console.ReadLine());
        if (func == 1)
        {
            sity = "Moscow";
        }
        else
        {
            Console.WriteLine("Введите название города на английском языке");
            sity = Console.ReadLine();
        }
       
        string cityName = args.Length > 0 ? args[0] : sity; 
        string apiKey = "1e2d1462c0194f178da5457bc5c64ec0"; 
        string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";

        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            WeatherData data = JsonSerializer.Deserialize<WeatherData>(json);
            Console.WriteLine($"Температура в городе {cityName}: {data.main.temp}°C");
        }
        else
        {
            Console.WriteLine("Не удалось получить данные о погоде.");
        }
    }
}

class WeatherData
{
    public Weather[] weather { get; set; }
    public MainInfo main { get; set; }
}

class Weather
{
    public string description { get; set; }
}

class MainInfo
{
    public float temp { get; set; }
}