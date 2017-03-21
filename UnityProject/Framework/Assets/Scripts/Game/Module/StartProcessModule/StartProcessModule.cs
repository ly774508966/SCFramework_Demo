using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SCFramework;

namespace Game.Demo
{
    public class StartProcessModule : AbstractStartProcess
    {

        protected override void InitExechuteContainer()
        {
            Append(new InitEnvironmentNode());
            Append(new LoadTableNode());
            Append(new InitModuleNode());

            Append(new LoginNode());
        }
    }
}
