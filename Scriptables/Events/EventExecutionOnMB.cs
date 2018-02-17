using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    public class EventExecutionOnMB : MonoBehaviour
    {
        /// <summary>
        /// Raise the event or comparison as soon as this gameObject is enabled
        /// </summary>
        public bool raiseOnEnable;
        /// <summary>
        /// Raise the event or comparison as soon as this gameObject is disabled
        /// </summary>
        public bool raiseOnDisable;
        
        void OnEnable()
        {
            if(raiseOnEnable)
            {
                Raise();
            }
        }

        void OnDisable()
        {
            if(raiseOnDisable)
            {
                Raise();
            }
        }

        public virtual void Raise()
        {

        }
    }
}
