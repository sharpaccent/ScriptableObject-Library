using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class ConditionalEvent_GameObjectState : EventExecutionOnMB
    {
        public GameObject targetGameObject;

        public UnityEvent IfTrue;
        public UnityEvent IfFalse;

        /// <summary>
        /// Invoke the true or false event stack based on a state of a gameObject. 
        /// Super useful when doing categories with UI elements.
        /// </summary>
        public override void Raise()
        {
            if(targetGameObject == null)
            {
                Debug.Log("Conditional Event from GameObject state doesn't have a gameobject assigned! " + this.gameObject.name);
                return;
            }

            if (targetGameObject.activeInHierarchy)
                IfTrue.Invoke();
            else
                IfFalse.Invoke();
        }
    }
}
