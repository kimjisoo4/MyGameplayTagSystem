﻿#if SCOR_ENABLE_VISUALSCRIPTING
using Unity.VisualScripting;

namespace StudioScor.GameplayTagSystem.VisualScripting
{
    [UnitTitle("On Added OwnedTag")]
    [UnitSubtitle("Event")]
    [UnitCategory("Events\\StudioScor\\GameplayTagSystem")]
    public class GameplayTagSystemAddOwnedTagEvent : GameplayTagSystemEventUnit
    {
        protected override string hookName => GameplayTagSystemVisualScriptingEvent.ADD_OWNED_TAG;
    }
}

#endif