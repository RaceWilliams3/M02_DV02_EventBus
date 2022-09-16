using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.EventBus
{
    public enum RaceEventType
    {
        COUNTDOWN, START, RESTART, PAUSE, STOP, FINISH, QUIT
    }

    public class RaceEventBus
    {
        private static readonly
            IDictionary<RaceEventType, UnityEvent>
            Events = new Dictionary<RaceEventType, UnityEvent>();

        public static void Subscribe (RaceEventType eventType, UnityAction listener)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(eventType, out thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }

        public static void Unsubscribe (RaceEventType type, UnityAction listener)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(type, out thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }

        public static void Publish(RaceEventType type)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(type, out thisEvent))
            {
                thisEvent.Invoke();
            }
        }
    }
}


