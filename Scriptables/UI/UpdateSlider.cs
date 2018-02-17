using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;
using UnityEngine.UI;

namespace SO.UI
{
    public class UpdateSlider : UIPropertyUpdater
    {
        public NumberVariable targetVariable;
        public Slider targetSlider;

        public override void Raise()
        {
            if(targetVariable is FloatVariable)
            {
                FloatVariable f = (FloatVariable)targetVariable;
                targetSlider.value = f.value;
                return;
            }

            if(targetVariable is IntVariable)
            {
                IntVariable i = (IntVariable)targetVariable;
                targetSlider.value = i.value;
            }
        }
    }
}
