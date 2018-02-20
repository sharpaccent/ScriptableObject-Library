using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent gameEvent;
        public UnityEvent response;

        /// <summary>
        /// Override this to override the OnEnableLogic()
        /// </summary>
        public virtual void OnEnableLogic()
        {
            if (gameEvent != null)
                gameEvent.Register(this);
        }

        void OnEnable()
        {
            OnEnableLogic();
        }

        /// <summary>
        /// Override this to override the OnDisableLogic()
        /// </summary>
        public virtual void OnDisableLogic()
        {
            if (gameEvent != null)
                gameEvent.UnRegister(this);
        }

        void OnDisable()
        {
            OnDisableLogic();
        }

        public virtual void Response()
        {
            response.Invoke();
        }
    }
}
