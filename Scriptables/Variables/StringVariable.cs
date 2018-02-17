using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/String")]
    public class StringVariable : ScriptableObject
    {
        public string value;

        public void Set(string v)
        {
            value = v;
        }

        public void Set(StringVariable v)
        {
            value = v.value;
        }

        public bool IsEmptyOrNull()
        {
            return string.IsNullOrEmpty(value);
        }

        public void Clear()
        {
            value = string.Empty;
        }
    }
}
