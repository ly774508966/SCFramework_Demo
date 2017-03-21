using UnityEngine;
using System.Collections;
using SCFramework;
using UnityEngine.UI;

namespace Game.Demo
{
    public class FuncDesPanel : AbstractPanel
    {
        public interface IAdapter
        {
            string funcDesc { get; }
        }

        [SerializeField]
        private Text m_DisplayText;

        private IAdapter m_Adapter;

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

            m_DisplayText.text = m_Adapter.funcDesc;
        }
    }
}
