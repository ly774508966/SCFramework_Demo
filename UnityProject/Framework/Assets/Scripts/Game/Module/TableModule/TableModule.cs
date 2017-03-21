using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SCFramework;

namespace Game.Demo
{
    public class TableModule : AbstractModule
    {
        protected override void OnComAwake()
        {
            InitPreLoadTableMetaData();
            InitDelayLoadTableMetaData();

            actor.StartCoroutine(TableMgr.S.PreReadAll(OnTableLoadFinish));
        }

        private void OnTableLoadFinish()
        {
            TDConstTable.InitArrays(typeof(ConstType));
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
