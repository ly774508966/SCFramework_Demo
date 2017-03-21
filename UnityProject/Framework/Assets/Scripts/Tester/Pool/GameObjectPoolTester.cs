using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SCFramework;

namespace Game.Demo
{
    public class GameObjectPoolTester : MonoBehaviour
    {
        [SerializeField]
        GameObject m_Prefab1;
        [SerializeField]
        GameObject m_Prefab2;

        [SerializeField]
        Transform m_Root1;
        [SerializeField]
        Transform m_Root2;
        void Awake()
        {
            GameObjectPoolMgr.S.AddPool("pool1", m_Prefab1, 20, 10);
            GameObjectPoolMgr.S.AddPool("pool2", m_Prefab2, 20, 10);
        }

        void Start()
        {
            Invoke("StartTest", 5);
        }

        private void StartTest()
        {
            AllocateRoot1();
            AllocateRoot2();
        }

        private void AllocateRoot2()
        {
            for (int i = 0; i < 10; ++i)
            {
                var obj = GameObjectPoolMgr.S.Allocate("pool2");
                obj.transform.SetParent(m_Root2, true);
            }

            InvokeRepeating("RecycleRoot2", 0.3f, 0.3f);
        }

        private void AllocateRoot1()
        {
            for (int i = 0; i < 10; ++i)
            {
                var obj = GameObjectPoolMgr.S.Allocate("pool1");
                obj.transform.SetParent(m_Root1, true);
            }

            InvokeRepeating("RecycleRoot1", 0.2f, 0.2f);
        }

        private void RecycleRoot1()
        {
            int count = m_Root1.childCount;
            if (count > 0)
            {
                Transform child = m_Root1.GetChild(count - 1);
                GameObjectPoolMgr.S.Recycle(child.gameObject);
            }
            else
            {
                CancelInvoke("RecycleRoot1");
                Invoke("AllocateRoot1", 0.2f);
            }
        }

        private void RecycleRoot2()
        {
            int count = m_Root2.childCount;
            if (count > 0)
            {
                Transform child = m_Root2.GetChild(count - 1);
                GameObjectPoolMgr.S.Recycle(child.gameObject);
            }
            else
            {
                CancelInvoke("RecycleRoot2");
                Invoke("AllocateRoot2", 0.2f);
            }
        }

    }
}
