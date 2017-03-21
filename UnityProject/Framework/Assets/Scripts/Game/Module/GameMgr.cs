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
                    s_Instance = TMonoSingleton<ApplicationMgr>.CreateMonoSingleton<GameMgr>();
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
            //初始化资源系统
            ResMgr.S.InitResMgr();
            AppConfig.S.InitAppConfig();

            if (AppConfig.S.dumpToFile)
            {
                DebugLogger.S.InitDebugLogger();
            }

            AddCom<UIDataModule>();

            AddCom<InputModule>();
            UIMgr.S.OpenPanel(UIID.MainPanel);
        }
    }
}
