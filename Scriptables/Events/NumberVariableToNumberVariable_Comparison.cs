using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class NumberVariableToNumberVariable_Comparison : EventExecutionOnMB
    {
        public NumberVariable value1;
        public NumberVariable value2;

        public UnityEvent IfValue1IsLower;
        public UnityEvent IfValue1IsHigher;

        /// <summary>
        /// Raise true or false event stack based on the comparison of two number variables
        /// </summary>
        public override void Raise()
        {
            if(value1 == null || value2 == null)
            {
                Debug.Log("Number variable comparison doesn't have variables assigned! " + this.gameObject);
                return;
            }

            float v1 = 0;
            float v2 = 0;

            if(value1 is FloatVariable)
            {
                FloatVariable f = (FloatVariable)value1;
                v1 = f.value;
            }

            if(value1 is IntVariable)
            {
                IntVariable i = (IntVariable)value1;
                v1 = i.value;
            }

            if (value2 is FloatVariable)
            {
                FloatVariable f = (FloatVariable)value2;
                v2 = f.value;
            }

            if (value2 is IntVariable)
            {
                IntVariable i = (IntVariable)value2;
                v2 = i.value;
            }

            if(v1 < v2)
            {
                IfValue1IsLower.Invoke();
            }
            else
            {
                IfValue1IsHigher.Invoke();
            }
            
        }

    }
}
