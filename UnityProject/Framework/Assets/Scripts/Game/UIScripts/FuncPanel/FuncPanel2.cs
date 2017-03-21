using UnityEngine;
using System.Collections;
using SCFramework;
using UnityEngine.UI;
using System;

namespace Game.Demo
{
    public class FuncPanel2 : AbstractPanel, FuncDesPanel.IAdapter, NavigationPanel.IAdapter
    {
        [SerializeField]
        private InputField      m_InputField;
        [SerializeField]
        private Button          m_SyncButton;
        [SerializeField]
        private Image           m_DisplayImage;

        public string funcDesc
        {
            get
            {
                return "Sprite 动态切换";
            }
        }

        public string panelName
        {
            get
            {
                return "FuncPanel2";
            }
        }

        protected override void OnPanelOpen(params object[] args)
        {
            OpenDependPanel(UIID.FuncDesPanel, this);
            OpenDependPanel(UIID.NavigationPanel, this);
        }

        protected override void OnUIInit()
        {
            m_SyncButton.onClick.AddListener(OnClickSyncButton);
        }

        private void OnClickSyncButton()
        {
            m_DisplayImage.sprite = FindSprite(m_InputField.text);
        }

        public void OnCloseClick()
        {
            CloseSelfPanel();
        }
    }
}
