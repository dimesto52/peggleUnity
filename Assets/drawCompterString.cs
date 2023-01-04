using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class drawCompterString : MonoBehaviour
{

    TMPro.TMP_Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TMPro.TMP_Text>();

        compterBall.compter.compterChange += UpdateText;
        UpdateText(compterBall.compter.numBall);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateText(int i)
    {
        txt.text = "x" + i.ToString();
    }
}
