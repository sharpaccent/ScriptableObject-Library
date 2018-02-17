using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Float")]
    public class FloatVariable : NumberVariable
    {
        public float value;

        public void Set(float v)
        {
            value = v;
        }

        public void Set(NumberVariable v)
        {
            if (v is FloatVariable)
            {
                FloatVariable f = (FloatVariable)v;
                value = f.value;
            }

            if (v is IntVariable)
            {
                IntVariable i = (IntVariable)v;
                value = i.value;
            }
        }

        public void Add(float v)
        {
            value += v;
        }

        public void Add(NumberVariable v)
        {
            if (v is FloatVariable)
            {
                FloatVariable f = (FloatVariable)v;
                value += f.value;
            }

            if (v is IntVariable)
            {
                IntVariable i = (IntVariable)v;
                value += i.value;
            }
        }
    }
}
