// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub:   https://github.com/RimuruDev
//
// **************************************************************** //

using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using AbyssMoth.Plugins.UnityPauseSystem.Common;

namespace AbyssMoth.Plugins.UnityPauseSystem.Core
{
    public class PauseSystem : MonoSingleton<PauseSystem>, IPauseSystem
    {
        private readonly List<IPausable> pausableComponents = new();
        private bool isPaused;

        protected override void Awake()
        {
            base.Awake();

            SceneManager.sceneLoaded += OnSceneLoaded;

            CachePausableComponents();
        }

        private void OnDestroy() =>
            SceneManager.sceneLoaded -= OnSceneLoaded;

        private void OnSceneLoaded(Scene scene, LoadSceneMode mode) =>
            CachePausableComponents();

        public void Register(IPausable pausable)
        {
            if (!pausableComponents.Contains(pausable))
                pausableComponents.Add(pausable);
        }

        public void Unregister(IPausable pausable) =>
            pausableComponents.Remove(pausable);

        public void PauseAll()
        {
            if (isPaused)
                return;

            isPaused = true;

            foreach (var pausable in pausableComponents)
                pausable.OnPause();
        }

        public void ResumeAll()
        {
            if (!isPaused)
                return;

            isPaused = false;

            foreach (var pausable in pausableComponents)
                pausable.OnResume();
        }

        public bool IsPaused() => isPaused;

        private void CachePausableComponents()
        {
            pausableComponents.Clear();
            var components = FindObjectsOfType<MonoBehaviour>(true).Where(x => x != null).OfType<IPausable>().ToArray();
            pausableComponents.AddRange(components);
        }
    }
}