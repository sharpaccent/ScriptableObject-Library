using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SO.UI
{
    public class UIPropertyUpdater : MonoBehaviour
    {
        /// <summary>
        /// Use this to update the UI element as soon as THIS gameObject is enabled
        /// </summary>
        public bool raiseOnEnable;

        /// <summary>
        /// In the off chance you need to update a UI element when disabled, just add the OnDisable() method
        /// </summary>

        public virtual void Raise()
        {
            
        }

        void OnEnable()
        {
            if(raiseOnEnable)
            {
                Raise();
            }
        }
    }
}
