using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    public class DelayedEvent : MonoBehaviour
    {
        public GameEvent targetEvent;

        /// <summary>
        /// Use this to raise an event after some time has passed
        /// </summary>
        public void Raise(float timer)
        {
            StartCoroutine(DelayedRaise(timer));
        }

        IEnumerator DelayedRaise(float t)
        {
            yield return new WaitForSeconds(t);
            targetEvent.Raise();
        }
      
    }
}
