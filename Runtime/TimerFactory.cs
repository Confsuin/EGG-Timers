using System;

namespace EGG.Timers
{
    public static class TimerFactory
    {
        public static ITimer CreateCooldownTimer(ITimerOwner owner, Action onCompleted = null)
        {
            return CreateDurationTimer(owner, onCompleted, false);
        }

        public static ITimer CreateDurationTimer(ITimerOwner owner, Action onCompleted = null, bool autoRemoveOnComplete = true)
        {
            Timer timer = new();
            timer.OnTimerCompleted += onCompleted;
            timer.AutoRemoveOnComplete = autoRemoveOnComplete;
            timer.Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            timer.Register();
            return timer;
        }

        public static ITickTimer CreateTickTimer(ITimerOwner owner, Action onTick = null)
        {
            TickTimer tickTimer = new();
            tickTimer.OnTick += onTick;
            tickTimer.Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            tickTimer.Register();
            return tickTimer;
        }
    }
}