using UnityEngine;
using System.Collections;
using SCFramework;
using UnityEngine.UI;
using System;

namespace Game.Demo
{
    public class FuncPanel1 : AbstractPanel, NavigationPanel.IAdapter
    {
        [SerializeField]
        private Text m_Title;

        public string panelName
        {
            get
            {
                return "FuncPanel1";
            }
        }

        public void OnCloseClick()
        {
            CloseSelfPanel();
        }

        protected override void OnPanelOpen(params object[] args)
        {
            OpenDependPanel(UIID.NavigationPanel, this);

            if (args.Length > 0)
            {
                m_Title.text = string.Format("Panel1:{0}", args[0]);
            }
        }
    }
}
