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
