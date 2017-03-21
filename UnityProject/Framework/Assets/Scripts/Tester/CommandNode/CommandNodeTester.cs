using UnityEngine;
using System.Collections;
using SCFramework;

namespace Game.Demo
{

    public class CommandNodeTester : MonoBehaviour
    {
        private class Node1 : CommandNode
        {
            private string m_Msg;

            public Node1(string value)
            {
                m_Msg = value;
            }

            public override void Start()
            {
                Log.i(m_Msg);
                FinishCommand();
            }
        }

        private class TimeDelayNode : CommandNode
        {
            private float m_DelayTime;
            private string m_Msg;

            public TimeDelayNode(string msg, float delayTime)
            {
                m_Msg = msg;
                m_DelayTime = delayTime;
            }

            public override void Start()
            {
                Log.i("Begin:" + m_Msg);
                Timer.S.Post2Really(OnTimeReach, m_DelayTime);
            }

            private void OnTimeReach(int count)
            {
                Log.i("End:" + m_Msg);
                FinishCommand();
            }
        }

        private CommandSequence m_CommandNode;

        private void Awake()
        {
            m_CommandNode = new CommandSequence();
            m_CommandNode.Append(new Node1("Begin1"));
            m_CommandNode.Append(new Node1("********************"));
            m_CommandNode.Append(new TimeDelayNode("Delay2", 2));
            m_CommandNode.Join(new TimeDelayNode("Delay3", 4));
            m_CommandNode.Join(new Node1("Msg4"));

            m_CommandNode.Append(new Node1("Msg5"));
        }

        private void Start()
        {
            m_CommandNode.Start();
        }
    }
}
