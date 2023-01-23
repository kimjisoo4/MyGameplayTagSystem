﻿#if SCOR_ENABLE_VISUALSCRIPTING
using Unity.VisualScripting;

namespace StudioScor.GameplayTagSystem.VisualScripting
{
    [UnitTitle("On Granted OwnedTag")]
    [UnitSubtitle("Event")]
    [UnitCategory("Events\\StudioScor\\GameplayTagSystem")]
    public class GameplayTagSystemGrantOwnedTagEvent : GameplayTagSystemEventUnit
    {
        protected override string hookName => GameplayTagSystemVisualScriptingEvent.GRANT_OWNED_TAG;
    }
}

#endif