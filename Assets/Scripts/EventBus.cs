using System;

public static class EventBus
{
    // Declare the delegate and event for a target hit
    public static event Action<Target> OnTargetHit;

    // Method to raise the event
    public static void TargetHit(Target target)
    {
        OnTargetHit?.Invoke(target);
    }
}