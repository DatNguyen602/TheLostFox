using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Image mask;
    float originalSize;
    static BossHealthBar instance;

    void Start()
    {
        originalSize = mask.rectTransform.rect.width;
        instance = this;
    }

    public void SetValue(float value)
    {
        mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }


    public static  BossHealthBar getInstance()
    {
        return instance;
    }
}
