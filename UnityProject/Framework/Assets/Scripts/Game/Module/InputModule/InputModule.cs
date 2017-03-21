using UnityEngine;
using System.Collections;
using SCFramework;
using UnityEngine.SceneManagement;

namespace Game.Demo
{
    public class InputModule : AbstractModule
    {
        private IInputter m_KeyboardInputter;

        public override void OnComLateUpdate(float dt)
        {
            m_KeyboardInputter.LateUpdate();
        }

        protected override void OnComAwake()
        {
            m_KeyboardInputter = new KeyboardInputter();

            m_KeyboardInputter.RegisterKeyCodeMonitor(KeyCode.F1, null, OnClickF1, null);
            m_KeyboardInputter.RegisterKeyCodeMonitor(KeyCode.F2, null, OnClickF2, null);
            m_KeyboardInputter.RegisterKeyCodeMonitor(KeyCode.F3, null, OnClickF3, null);
            m_KeyboardInputter.RegisterKeyCodeMonitor(KeyCode.F4, null, OnClickF4, null);
        }

        private void OnClickF1()
        {
            FloatMessage.S.ShowMsg("....");
        }

        private int clickIndex = 0;
        private void OnClickF2()
        {
            MsgBox.S.Show("title", string.Format("Click Count:{0}", ++clickIndex), false);
        }

        private void OnClickF3()
        {
            UIMgr.S.OpenPanel(UIID.FuncPanel1, ++clickIndex);
        }

        private void OnClickF4()
        {
            SceneMgr.S.SwitchSceneAsync("demo2", OnSceneLoadResult, LoadSceneMode.Single);
        }

        private void OnSceneLoadResult(string sceneName, bool result)
        {
            Log.i("SceneLoad:" + sceneName + " " + result);
        }
    }
}
