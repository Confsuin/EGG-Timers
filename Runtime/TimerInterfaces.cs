using System;

namespace EGG.Timers
{
    public interface ITimer
    {
        ITimerOwner Owner { get; set; }
        bool IsRunning { get; }
        bool AutoRemoveOnComplete { get; set; }
        bool MarkedForRemoval { get; }
        float RemainingTime { get; }
        void Start(float duration);
        void Stop();
        void Dispose();
        void Tick(float deltaTime);
        void Pause();
        void Unpause();
        void Decrement(float amount);
        void Increment(float amount);

        event Action OnTimerCompleted;
    }
    public interface ITickTimer
    {
        ITimerOwner Owner { get; set; }
        bool IsRunning { get; }
        bool AutoRemoveOnStop { get; set; }
        bool MarkedForRemoval { get; }
        bool HasDuration { get; set; }
        float RemainingTime { get; }

        void Start(float interval);
        void Start(float interval, float duration);
        void Stop();
        void Dispose();
        void Tick(float deltaTime);
        void Pause();
        void Unpause();
        void IncrementTick(float amount);
        void DecrementTick(float amount);
        void IncrementDuration(float amount);
        void DecrementDuration(float amount);

        event Action OnTick;
        event Action OnTimerCompleted;
    }
    public interface ITimerOwner
    {

    }
}