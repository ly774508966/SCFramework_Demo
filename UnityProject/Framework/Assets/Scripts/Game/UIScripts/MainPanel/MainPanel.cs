using UnityEngine;
using System.Collections;
using SCFramework;
using System;

namespace Game.Demo
{
    public class MainPanel : AbstractPanel, NavigationPanel.IAdapter
    {
        public static string PrepareDynamicResource()
        {
            UIData data = UIDataTable.Get(UIID.NavigationPanel);
            return data.fullPath;
        }

        public string panelName
        {
            get
            {
                return "MainPanel";
            }
        }

        public void OnCloseClick()
        {
            
        }

        protected override void OnUIInit()
        {
            OpenDependPanel(UIID.NavigationPanel, this);
        }
    }
}
