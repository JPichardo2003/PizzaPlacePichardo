using System.Text.Json;

namespace PizzaPlaceApp.Clients
{
    public static class ExtDepuracion
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
