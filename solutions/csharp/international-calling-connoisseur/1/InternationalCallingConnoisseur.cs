public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return [];
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string> { { 1, "United States of America" }, { 55, "Brazil" }, { 91, "India" } }
        ;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new Dictionary<int, string> { { countryCode, countryName } };
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (CheckCodeExists(existingDictionary, countryCode))
            return existingDictionary[countryCode];
        return "";
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (CheckCodeExists(existingDictionary, countryCode))
            existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        if (existingDictionary.Count == 0)
            return "";
        return existingDictionary.OrderByDescending(c => c.Value.Length).FirstOrDefault().Value;
    }
}