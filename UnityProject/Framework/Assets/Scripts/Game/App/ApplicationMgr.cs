using UnityEngine;
using System.Collections;
using SCFramework;
using DG.Tweening;

namespace Game.Demo
{
    [TMonoSingletonAttribute("[App]/ApplicationMgr")]
    public class ApplicationMgr : AbstractApplicationMgr<ApplicationMgr>
    {

        protected override void InitThirdLibConfig()
        {
            DOTween.Init(false, true, LogBehaviour.ErrorsOnly);

            DOTween.defaultEaseType = Ease.Linear;
        }

        protected override void InitAppEnvironment()
        {

        }

        protected override void StartGame()
        {
            //new GameObject("StartProcess").AddComponent<StartProcess>();
            GameMgr.S.InitGameMgr();
        }

    }
}
