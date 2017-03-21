using UnityEngine;
using System.Collections;
using SCFramework;

namespace Game.Demo
{
    public class AppLoader : MonoBehaviour
    {
        private void Awake()
        {
            Log.i("Init[{0}]", ApplicationMgr.S.GetType().Name);
        }

        private void Start()
        {
            Destroy(gameObject);
        }
    }
}
