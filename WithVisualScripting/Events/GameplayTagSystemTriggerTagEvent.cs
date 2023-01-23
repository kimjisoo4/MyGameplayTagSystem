﻿#if SCOR_ENABLE_VISUALSCRIPTING
using Unity.VisualScripting;

namespace StudioScor.GameplayTagSystem.VisualScripting
{

    [UnitTitle("On Trigger GameplayTag")]
    [UnitSubtitle("Event")]
    [UnitCategory("Events\\StudioScor\\GameplayTagSystem")]
    public class GameplayTagSystemTriggerTagEvent : GameplayTagSystemEventUnit
    {
        protected override string hookName => GameplayTagSystemVisualScriptingEvent.TRIGGER_TAG;
    }
}

#endif