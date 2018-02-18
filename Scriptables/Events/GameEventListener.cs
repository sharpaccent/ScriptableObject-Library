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

        void OnEnable()
        {
            if(gameEvent != null)
                gameEvent.Register(this);
        }

        void OnDisable()
        {
            if (gameEvent != null)
                gameEvent.UnRegister(this);
        }

        public virtual void Response()
        {
            response.Invoke();
        }
    }
}
