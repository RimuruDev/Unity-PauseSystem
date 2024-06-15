// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub:   https://github.com/RimuruDev
//
// **************************************************************** //

namespace AbyssMoth.Plugins.UnityPauseSystem.Core
{
    public interface IPauseSystem
    {
        public void PauseAll();
        public void ResumeAll();

        public bool IsPaused();

        public void Register(IPausable pausable);
        public void Unregister(IPausable pausable);
    }
}