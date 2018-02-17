using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Integer")]
    public class IntVariable : NumberVariable
    {
        public int value;

        public void Set(int v)
        {
            value = v;
        }

        public void Set(NumberVariable v)
        {
            if(v is FloatVariable)
            {
                FloatVariable f = (FloatVariable)v;
                value = Mathf.RoundToInt(f.value);
            }

            if(v is IntVariable)
            {
                IntVariable i = (IntVariable)v;
                value = i.value;
            }
        }

        public void Add(int v)
        {
            value += v;
        }
        
        public void Add(NumberVariable v)
        {
            if (v is FloatVariable)
            {
                FloatVariable f = (FloatVariable)v;
                value += Mathf.RoundToInt(f.value);
            }

            if (v is IntVariable)
            {
                IntVariable i = (IntVariable)v;
                value += i.value;
            }
        }
    }
}
