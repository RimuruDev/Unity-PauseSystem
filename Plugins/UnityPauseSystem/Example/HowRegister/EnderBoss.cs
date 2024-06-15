// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub:   https://github.com/RimuruDev
//
// **************************************************************** //

using UnityEngine;
using AbyssMoth.Plugins.UnityPauseSystem.Core;

namespace AbyssMoth.Plugins.UnityPauseSystem.Example.HowRegister
{
    //
    // Hand Register or Register in Awake
    //
    public class EnderBoss : MonoBehaviour, IPausable
    {
        private void Awake()
        {
            // Register pause
            if (PauseSystem.HasInstance)
            {
                PauseSystem.Instance.Register(this);
            }
        }

        private void OnDestroy()
        {
            // Unregister pause
            if (PauseSystem.HasInstance)
            {
                PauseSystem.Instance.Unregister(this);
            }
        }

        public void OnPause()
        {
            Debug.Log("Pause EnderBoss");
        }

        public void OnResume()
        {
            Debug.Log("Resume EnderBoss");
        }
    }
}