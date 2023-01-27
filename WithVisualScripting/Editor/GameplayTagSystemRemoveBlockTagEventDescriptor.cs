﻿
#if SCOR_ENABLE_VISUALSCRIPTING
using Unity.VisualScripting;

namespace StudioScor.GameplayTagSystem.VisualScripting.Editor
{
    [Descriptor(typeof(GameplayTagSystemRemoveBlockTagEvent))]
    public sealed class GameplayTagSystemRemoveBlockTagEventDescriptor : UnitDescriptor<GameplayTagSystemRemoveBlockTagEvent>
    {
        public GameplayTagSystemRemoveBlockTagEventDescriptor(GameplayTagSystemRemoveBlockTagEvent target) : base(target)
        {
        }

        protected override EditorTexture DefaultIcon()
        {
            return GameplayTagSystemPathUtility.Load("T_RemoveBlockTag_D");
        }
        protected override EditorTexture DefinedIcon()
        {
            return GameplayTagSystemPathUtility.Load("T_RemoveBlockTag_D");
        }
    }
}

#endif