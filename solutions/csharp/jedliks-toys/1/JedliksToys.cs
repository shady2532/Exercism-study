class RemoteControlCar
{
    private int distance = 0;
    private int batteryUsage = 0;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if (batteryUsage >= 100) return "Battery empty";
        return $"Battery at {100 - batteryUsage}%";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if (batteryUsage >= 100) return;        
        distance += 20;
        batteryUsage += 1;
    }
}
