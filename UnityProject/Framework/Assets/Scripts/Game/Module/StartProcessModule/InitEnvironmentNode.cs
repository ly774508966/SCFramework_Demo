using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SCFramework;

namespace Game.Demo
{
    public class InitEnvironmentNode : ExecuteNode
    {
        public override void OnBegin()
        {
            Log.i("ExecuteNode:" + GetType().Name);
            ResMgr.S.InitResMgr();
            AppConfig.S.InitAppConfig();

            if (AppConfig.S.dumpToFile)
            {
                DebugLogger.S.InitDebugLogger();
            }

            isFinish = true;
        }
    }
}
