using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.EventBus
{
    public class HUDController : MonoBehaviour
    {
        private bool _isDisplayOn;

        void OnEnable()
        {
            RaceEventBus.Subscribe(RaceEventType.START, DisplayHUD);
        }

        void OnDisable()
        {
            RaceEventBus.Unsubscribe(RaceEventType.START, DisplayHUD);
        }

        private void DisplayHUD()
        {
            _isDisplayOn = true;
        }

        void OnGUI()
        {
            if (_isDisplayOn)
            {
                if (GUILayout.Button("STOP RACE"))
                {
                    _isDisplayOn = false;

                    RaceEventBus.Publish(RaceEventType.STOP);
                }
            }
        }
    }
}