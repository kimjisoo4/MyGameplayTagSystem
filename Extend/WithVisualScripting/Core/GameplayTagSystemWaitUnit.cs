﻿#if SCOR_ENABLE_VISUALSCRIPTING
using System;
using System.Collections;
using Unity.VisualScripting;

namespace StudioScor.GameplayTagSystem.VisualScripting
{

    public abstract class GameplayTagSystemWaitUnit : GameplayTagSystemUnit
    {
        [DoNotSerialize]
        [PortLabel("Enter")]
        [PortLabelHidden]
        public ControlInput Enter;

        [DoNotSerialize]
        [PortLabel("Exit")]
        [PortLabelHidden]
        public ControlOutput Exit;


        protected override void Definition()
        {
            base.Definition();

            Enter = ControlInputCoroutine(nameof(Enter), Await);
            Exit = ControlOutput(nameof(Exit));

            Succession(Enter, Exit);
            Requirement(GameplayTagSystemComponent, Enter);
        }

        protected abstract IEnumerator Await(Flow arg);
    }
}

#endif