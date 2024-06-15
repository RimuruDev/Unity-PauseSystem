using System;
using AbyssMoth.Plugins.UnityPauseSystem.Core;
using UnityEngine;

namespace AbyssMoth.Plugins.UnityPauseSystem.Example.HowPauseResume
{
    public class Test : MonoBehaviour, IPausable
    {
        [SerializeField] private PauseSystem pauseSystem;

        private void Awake()
        {
            pauseSystem = PauseSystem.Instance;
        }

        private void Start()
        {
            // PauseAll All IPausable in scene
            pauseSystem.PauseAll();

            // Resume All IPausable in scene
            pauseSystem.ResumeAll();

            // Register this class
            pauseSystem.Register(this);

            // Unregister this class
            pauseSystem.Unregister(this);
        }

        public void OnPause()
        {
        }

        public void OnResume()
        {
        }
    }
}