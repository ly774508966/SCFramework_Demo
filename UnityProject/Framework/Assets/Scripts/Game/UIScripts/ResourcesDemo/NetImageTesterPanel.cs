using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SCFramework;

namespace Game.Demo
{
    public class NetImageTesterPanel : AbstractPanel
    {
        [SerializeField]
        private ListView m_ListView;

        protected override void OnUIInit()
        {
            m_ListView.cellUpdateDelegate = OnCellRenderer;
        }

        private void OnCellRenderer(Transform root, int index)
        {
            NetImageView view = root.GetComponent<NetImageView>();
            view.ScrollCellIndex(index);
        }
    }
}
