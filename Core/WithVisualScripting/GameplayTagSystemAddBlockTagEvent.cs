﻿#if SCOR_ENABLE_VISUALSCRIPTING
using Unity.VisualScripting;

namespace StudioScor.GameplayTagSystem
{
    [UnitTitle("OnAddBlockTagEvent")]
    [UnitCategory("Events\\StudioScor\\GameplayTagSystem")]
    public class GameplayTagSystemAddBlockTagEvent : GameplayTagSystemCustomUnitEvent
    {
        protected override string EventName => GameplayTagSystemVisualScriptingEvent.ADD_BLOCK_TAG;
    }
}

#endif