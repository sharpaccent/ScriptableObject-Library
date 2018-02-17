using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SO;

namespace SO.UI
{
    public class UpdateImage : UIPropertyUpdater
    {
        public SpriteVariable spriteVariable;
        public Image targetImage;

        /// <summary>
        /// Update the sprite of an Image UI element based on what you've set on the sprite variable
        /// </summary>
        public override void Raise()
        {
            targetImage.sprite = spriteVariable.value;
        }
    }
}
