using UnityEngine;
using System.Collections;
using SCFramework;

namespace Game.Demo
{
    public class UIDataModule : AbstractModule
    {
        protected override void OnComAwake()
        {
            PanelData.PREFIX_PATH = "Resources/Demo/UI/Panels/{0}";
            PageData.PREFIX_PATH = "Resources/Demo/UI/Panels/{0}";

            RegisterAllPanel();
        }

        private void RegisterAllPanel()
        {
            UIDataTable.SetABMode(false);

            UIDataTable.AddPanelData(EngineUI.FloatMessagePanel, null, "Common/FloatMessagePanel", true, 1);
            UIDataTable.AddPanelData(EngineUI.MsgBoxPanel, null, "Common/MsgBoxPanel", true, 1);

            //这个面板可以测试Singleton的区别
            UIDataTable.AddPanelData(UIID.FuncDesPanel, null, "Common/FuncDescPanel", true, 0);

            UIDataTable.AddPanelData(UIID.FuncPanel1, null, "FuncPanel/FuncPanel1", true, 0);
            UIDataTable.AddPanelData(UIID.FuncPanel2, null, "FuncPanel/FuncPanel2", true, 0);
            UIDataTable.AddPanelData(UIID.FuncPanel3, null, "FuncPanel/FuncPanel3", true, 0);
            UIDataTable.AddPanelData(UIID.FuncPanel4, null, "FuncPanel/FuncPanel4", true, 0);
			UIDataTable.AddPanelData(UIID.FuncPanel5, null, "FuncPanel/FuncPanel5", false, 0);

            UIDataTable.AddPanelData(UIID.GamePanel, typeof(GamePanel), "GamePanel/GamePanel", true, 0);
            UIDataTable.AddPanelData(UIID.NavigationPanel, null, "NavigationPanel/NavigationPanel", true, 1);
            UIDataTable.AddPanelData(UIID.MainPanel, typeof(MainPanel), "MainPanel/MainPanel", true, 0);
            UIDataTable.AddPanelData(UIID.LoginPanel, null, "LoginPanel/LoginPanel", true, 0);

            UIDataTable.AddPanelData(UIID.NetImageTesterPanel, null, "ResourceDemoPanel/NetImageTesterPanel", true, 0);
        }
    }
}
