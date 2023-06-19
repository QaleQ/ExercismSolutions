using System;

class RemoteControlCar
{
    int battery = 100;
    int distance;
    
    public static RemoteControlCar Buy() => new();
    public string DistanceDisplay() => $"Driven {distance} meters";
    public string BatteryDisplay() => battery > 0 ? $"Battery at {battery}%" : "Battery empty";
    public void Drive()
    {
        if (battery > 0)
        {
            distance += 20;
            battery -= 1;
        }
    }
}