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
    // Auto Register
    //
    public class InfernoTower : MonoBehaviour, IPausable
    {
        public void OnPause()
        {
            // Disable Rotation tower
            // Disable SFX
            // Ets...
            Debug.Log("Pause Tower");
        }

        public void OnResume()
        {
            // Enable Rotation tower
            // Enable SFX
            // Ets...
            Debug.Log("Resume Tower");
        }
    }
}