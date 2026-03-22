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
        bool MarkedForRemoval { get; }
        float RemainingTime { get; }

        void Start(float interval);
        void Stop();
        void Dispose();
        void Tick(float deltaTime);
        void Pause();
        void Unpause();
        void Increment(float amount);
        void Decrement(float amount);

        event Action OnTick;
    }
    public interface ITimerOwner
    {

    }
}