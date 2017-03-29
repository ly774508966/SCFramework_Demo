using UnityEngine;
using System.Collections;
using SCFramework;
using System;

namespace Game.Demo
{
    [TMonoSingletonAttribute("[Game]/GameMgr")]
    public class GameMgr : AbstractModuleMgr, ISingleton
    {
        private static GameMgr s_Instance;

        public static GameMgr S
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = MonoSingleton.CreateMonoSingleton<GameMgr>();
                }
                return s_Instance;
            }
        }

        public void InitGameMgr()
        {
            Log.i("Init[GameMgr]");
        }

        public void OnSingletonInit()
        {
            
        }

        protected override void OnActorStart()
        {
            StartProcessModule module = AddMonoCom<StartProcessModule>();

            module.SetFinishListener(OnStartProcessFinish);
        }

        protected void OnStartProcessFinish()
        {
            UIMgr.S.OpenPanel(UIID.MainPanel);
        }
    }
}
