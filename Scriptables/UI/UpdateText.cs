using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;
using UnityEngine.UI;

namespace SO.UI
{
    public class UpdateText : UIPropertyUpdater
    {
        public StringVariable targetString;
        public Text targetText;
        
        /// <summary>
        /// Use this to update a text UI element based on the target string variable
        /// </summary>
        public override void Raise()
        {
            targetText.text = targetString.value;
        }
        
        public void Raise(string target)
        {
            targetText.text = target;
        }
    }
}
