using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SCFramework;
using UnityEngine.UI;

namespace Game.Demo
{
    public class NavigationPanel : AbstractPanel
    {
        public interface IAdapter
        {
            string panelName { get; }
            void OnCloseClick();
        }

        [SerializeField]
        private Text        m_PanelNameLabel;
        [SerializeField]
        private Button      m_CloseButton;
        [SerializeField]
        private Transform   m_LinksToggleRoot;

        [SerializeField]
        private UIID[]      m_LinkButtonID;

        private IAdapter    m_Adapter;
        private int         m_CurrentIndex = -1;

        private int m_PrePanelUIID = -1;

        private List<Toggle> m_LinkToggles;

        private int UIID2Index(int uiID)
        {
            for (int i = 0; i < m_LinkButtonID.Length; ++i)
            {
                if (uiID == (int)m_LinkButtonID[i])
                {
                    return i;
                }
            }
            return -1;
        }

        protected override void OnUIInit()
        {
            m_CloseButton.onClick.AddListener(OnClickCloseButton);
            int childCount = m_LinksToggleRoot.childCount;
            m_LinkToggles = new List<Toggle>();

            for (int i = 0; i < childCount; ++i)
            {
                int index = i;
                Toggle toggle = m_LinksToggleRoot.GetChild(i).GetComponent<Toggle>();
                toggle.onValueChanged.AddListener((result) =>
                {
                    if (result)
                    {
                        SetSelectToggle(index);
                    }
                });
                m_LinkToggles.Add(toggle);
            }
        }

        protected override void OnOpen()
        {
            RegisterEvent(EngineEventID.OnPanelUpdate, OnTopPanelUpdate);
        }

        protected override void OnPanelOpen(params object[] args)
        {
            m_Adapter = null;

            if (args.Length > 0)
            {
                m_Adapter = args[0] as IAdapter;
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            if (m_Adapter == null)
            {
                return;
            }

            m_PanelNameLabel.text = m_Adapter.panelName;
        }

        private void OnTopPanelUpdate(int key, params object[] args)
        {
            int uiid = UIMgr.S.FindTopPanel(m_LinkButtonID);
            int index = UIID2Index(uiid);

            if (m_CurrentIndex >= 0)
            {
                m_LinkToggles[m_CurrentIndex].isOn = false;
            }

            m_CurrentIndex = index;

            if (m_CurrentIndex >= 0)
            {
                m_LinkToggles[m_CurrentIndex].isOn = true;
            }

            if (m_PrePanelUIID > 0 && m_PrePanelUIID != uiid)
            {
                UIMgr.S.ClosePanel(m_PrePanelUIID);
                m_PrePanelUIID = -1;
            }
        }

        private void SetSelectToggle(int index)
        {
            if (m_CurrentIndex == index)
            {
                return;
            }

            if (index < 0 || index >= m_LinkButtonID.Length)
            {
                return;
            }

            m_CurrentIndex = index;

            UIMgr.S.OpenPanel(m_LinkButtonID[index]);
        }

        private void OnClickCloseButton()
        {
            if (m_Adapter == null)
            {
                return;
            }

            m_Adapter.OnCloseClick();
        }
    }
}
