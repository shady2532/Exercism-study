class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var count in birdsPerDay)
        {
            if (count == 0)
            {
                return true;
            }
        }
        return false;
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            if (i >= birdsPerDay.Length) break;
            count += birdsPerDay[i];
        }
        return count;
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int busyDayCount = 0;
        foreach (var count in birdsPerDay)
        {
            if (count >= 5)
            {
                busyDayCount++;
            }
        }
        return busyDayCount;
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
