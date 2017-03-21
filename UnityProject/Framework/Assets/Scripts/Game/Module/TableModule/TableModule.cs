using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SCFramework;

namespace Game.Demo
{
    public class TableModule : AbstractModule
    {
        private bool m_IsTableLoadFinish = false;

        public bool isTableLoadFinish
        {
            get { return m_IsTableLoadFinish; }
        }

        protected override void OnComAwake()
        {
            InitPreLoadTableMetaData();
            InitDelayLoadTableMetaData();

            actor.StartCoroutine(TableMgr.S.PreReadAll(OnTableLoadFinish));
        }

        private void OnTableLoadFinish()
        {
            TDConstTable.InitArrays(typeof(ConstType));
            m_IsTableLoadFinish = true;
        }

        private void InitPreLoadTableMetaData()
        {
            TableConfig.preLoadTableArray = new TDTableMetaData[]
            {
                TDItemTable.metaData,
                TDConstTable.metaData,
                TDLanguageTable.metaData,
            };
        }

        private void InitDelayLoadTableMetaData()
        {
            TableConfig.delayLoadTableArray = new TDTableMetaData[]
            {

            };
        }
    }
}
