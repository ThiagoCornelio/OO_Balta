namespace UtmBuilder.Shared.Extensions
{
    public static class ListExtensions
    {
        public static void AddIfNotNull(
            this List<string> list,
            string key,
            string? value)
        {
            if (!string.IsNullOrWhiteSpace(value))
                list.Add($"{key}={value}");
        }
    }
}
