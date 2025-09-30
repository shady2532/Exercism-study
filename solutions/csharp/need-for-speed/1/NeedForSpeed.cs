class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private readonly int speed;
    private readonly int batteryDrain;
    private int battery = 100;
    private int distanceDriven = 0;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {
        if (flag || battery <= 0) return true;
        return false;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }
    bool flag = false;
    public void Drive()
    {

        if (battery >= batteryDrain)
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
        if (battery < batteryDrain)
        {
            battery = 0;
            flag = true;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private readonly int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && car.DistanceDriven() < distance)
        {
            car.Drive();
        }
        if (car.DistanceDriven() >= distance) return true;
        return false;
    }
}
