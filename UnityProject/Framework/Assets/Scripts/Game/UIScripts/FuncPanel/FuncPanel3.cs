using UnityEngine;
using System.Collections;
using SCFramework;
using UnityEngine.UI;

namespace Game.Demo
{
	public class FuncPanel3 : AbstractPanel, NavigationPanel.IAdapter
    {
        [SerializeField]
        private InputField m_InputField;
        [SerializeField]
        private Button m_SendButton;

		public string panelName
		{
			get
			{
				return "FuncPanel3";
			}
		}

		public void OnCloseClick()
		{
			CloseSelfPanel();
		}

        protected override void OnUIInit()
        {
            m_SendButton.onClick.AddListener(OnClickSendButton);
        }

        protected override void OnOpen()
        {
            RegisterEvent(EventID.OnPanel4Close, OnPanel4CloseEvent);
        }

		protected override void OnPanelOpen (params object[] args)
		{
			OpenDependPanel (UIID.NavigationPanel, this);
		}

        private void OnClickSendButton()
        {
            EventSystem.S.Send(EventID.OnSpriteUpdateEvent, m_InputField.text);
        }

        private void OnPanel4CloseEvent(int key, params object[] args)
        {
            CloseSelfPanel();
        }
    }
}
