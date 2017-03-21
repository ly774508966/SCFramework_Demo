using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SCFramework;

namespace Game.Demo
{
    public class InitModuleNode : ExecuteNode
    {
        public override void OnBegin()
        {
            Log.i("ExecuteNode:" + GetType().Name);
            GameMgr.S.AddCom<UIDataModule>();
            GameMgr.S.AddCom<InputModule>();
            isFinish = true;
        }
    }
}
