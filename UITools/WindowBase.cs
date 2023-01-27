using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.UI
{
    public class WindowBase : MonoBehaviour
    {
        public Button closeButton;
        public WindowAnimator animator;
        public bool isReusableView = true;
        [HideInInspector] public UnityEvent onClose = new UnityEvent();
        [HideInInspector] public bool active = false;
        private void Awake()
        {
            closeButton?.onClick.AddListener(Close);
        }
        public void Close()
        {
            WindowManager.instance.Close(this);
        }
        public virtual void OnOpened()
        {
            active = true;
        }
    }
}