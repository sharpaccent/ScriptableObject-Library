using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class NumberToNumberVariable_Comparison : EventExecutionOnMB
    {
        public float fixedNumber;
        public NumberVariable targetVariable;

        public UnityEvent IfVariableIsLower;
        public UnityEvent IfVariableIsHigher;

        /// <summary>
        /// Invoke the true or false event stack based on a comparison of your targetVariable and a fixed number
        /// The comparison only runs when the Raise() is called, it's not monitored in Update or etc.
        /// </summary>
        public override void Raise()
        {
            if(targetVariable == null)
            {
                Debug.Log("No number variable assigned in a fixed number to numberVariable comparison! " + this.gameObject.name);
                return;
            }

            if(targetVariable is FloatVariable)
            {
                FloatVariable f = (FloatVariable)targetVariable;
                if (f.value < fixedNumber)
                    IfVariableIsLower.Invoke();
                else
                    IfVariableIsHigher.Invoke();
            }

            if(targetVariable is IntVariable)
            {
                IntVariable i = (IntVariable)targetVariable;
                int v = Mathf.RoundToInt(fixedNumber);
                if (i.value < v)
                    IfVariableIsLower.Invoke();
                else
                    IfVariableIsHigher.Invoke();
            }
        }
    }
}
