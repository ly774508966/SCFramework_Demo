using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SCFramework;

namespace Game.Demo
{
    public enum StateID
    {
        kState1,
        kState2,
    }

    public class FSMTester : MonoBehaviour
    {
        
        class AbstractState : FSMState<FSMTester>
        {

        }

        
        class State1 : AbstractState
        {
            public override void Enter(FSMTester entity)
            {
                Log.i("Enter State 1.");
            }

            public override void Execute(FSMTester entity)
            {
                entity.stateMachine.SetCurrentStateByID(StateID.kState2);
            }

            public override void Exit(FSMTester entity)
            {
                Log.i("Ext State 1.");
            }
        }

        class State2 : AbstractState
        {
            public override void Enter(FSMTester entity)
            {
                Log.i("Enter State 2.");
            }

            public override void Execute(FSMTester entity)
            {
                entity.stateMachine.SetCurrentState(new State3());
            }

            public override void Exit(FSMTester entity)
            {
                Log.i("Ext State 2.");
            }
        }
        
        class State3 : AbstractState
        {
            public override void Enter(FSMTester entity)
            {
                Log.i("Enter State 3.");
            }

            public override void Exit(FSMTester entity)
            {
                Log.i("Ext State 3.");
            }
        }
        
        private FSMStateMachine<FSMTester> m_StateMachine;
        private FSMStateFactory<FSMTester> m_StateFactory;

        public FSMStateMachine<FSMTester> stateMachine
        {
            get { return m_StateMachine; }
        }

        void Awake()
        {
            m_StateFactory = new FSMStateFactory<FSMTester>(false);
            m_StateMachine = new FSMStateMachine<FSMTester>(this);
            m_StateMachine.stateFactory = m_StateFactory;

            m_StateFactory.RegisterCreator(StateID.kState1, State1Creator);
            m_StateFactory.RegisterCreator(StateID.kState2, State2Creator);
        }

        private void Start()
        {
            m_StateMachine.SetCurrentStateByID(StateID.kState1);
        }

        private void Update()
        {
            m_StateMachine.UpdateState();
        }

        
        AbstractState State1Creator()
        {
            return new State1();
        }

        AbstractState State2Creator()
        {
            return new State2();
        }
        
    }
}
