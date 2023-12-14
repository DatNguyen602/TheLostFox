using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StarUI : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Change(GameConfig.GetInstance().GetCurrentStar());
    }

    void Change(int star)
    {
        string count = "x" + star;
        text.text = count;
    }
}
