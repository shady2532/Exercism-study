public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        if (@base != 0 && multiplier > long.MaxValue / @base)
        {
            return "*** Too Big ***";
        }

        long result = @base * multiplier;
        return result.ToString();
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        if (@base != 0 && multiplier > long.MaxValue / @base)
        {
            return "*** Too Big ***";
        }

        float result = @base * multiplier;
        return result.ToString();
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        if (salaryBase != 0 && multiplier > long.MaxValue / salaryBase)
        {
            return "*** Much Too Big ***";
        }

        decimal result = salaryBase * multiplier;
        return result.ToString();
    }
}