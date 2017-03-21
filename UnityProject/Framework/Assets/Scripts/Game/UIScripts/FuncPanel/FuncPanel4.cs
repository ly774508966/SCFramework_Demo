using UnityEngine;
using System.Collections;
using SCFramework;
using UnityEngine.UI;

namespace Game.Demo
{
    public class FuncPanel4 : AbstractPanel
    {
        [SerializeField]
        private Image m_DisplayImage;
        [SerializeField]
        private Button m_CloseButton;

        protected override void OnUIInit()
        {
            m_CloseButton.onClick.AddListener(OnClickCloseButton);
        }

        protected override void OnOpen()
        {
            RegisterEvent(EventID.OnSpriteUpdateEvent, OnSpriteUpdateEvent);
        }

        protected override void OnPanelOpen(params object[] args)
        {
            int count = TDItemTable.count;
            for (int i = 0; i < count; ++i)
            {
                TDItem data = TDItemTable.dataList[i];
                Log.i(data.id + " " + data.itemDes);
            }

            Log.i("Const:" + TDConstTable.QueryInt(ConstType.ConstTest1));
            Log.i("Const:" + TDConstTable.QueryString(ConstType.ConstTest2));

            Log.i("Language:" + TDLanguageTable.Get("language_1"));
            Log.i("Language:" + TDLanguageTable.GetFormat("language_3", "askdha", "skjdhaskj"));
        }

        protected void OnSpriteUpdateEvent(int key, params object[] args)
        {
            if (args.Length == 0)
            {
                return;
            }

            m_DisplayImage.sprite = FindSprite(args[0] as string);
        }

        private void OnClickCloseButton()
        {
            EventSystem.S.Send(EventID.OnPanel4Close);
        }
    }
}
