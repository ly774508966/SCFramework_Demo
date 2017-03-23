using UnityEngine;
using System.Collections;
using SCFramework;
using UnityEngine.UI;
using System;

namespace Game.Demo
{
	public class FuncPanel5 : AbstractPanel, NavigationPanel.IAdapter
	{
		[SerializeField]
		private Text m_Title;
		[SerializeField]
		private Button m_CloseButton;
		[SerializeField]
		private Button m_CloseAllButton;
		[SerializeField]
		private Button m_OpenButton;

		private int m_Index = 0;
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

		protected override void OnUIInit ()
		{
			m_CloseButton.onClick.AddListener (OnClickCloseButton);
			m_CloseAllButton.onClick.AddListener (OnClickCloseAllButton);
			m_OpenButton.onClick.AddListener (OnClickOpenButton);
		}

		protected override void OnPanelOpen(params object[] args)
		{
			OpenDependPanel(UIID.NavigationPanel, this);

			if (args.Length > 0)
			{
				m_Index = (int)args [0];
			}

			m_Title.text = m_Index.ToString ();
		}

		private void OnClickCloseButton()
		{
			CloseSelfPanel ();
		}

		private void OnClickCloseAllButton()
		{
			UIMgr.S.ClosePanel (uiID);
		}

		private void OnClickOpenButton()
		{
			UIMgr.S.OpenPanel(uiID, ++m_Index);
		}
	}
}

