using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForScore : MonoBehaviour
{
    public int scoreE = 0;
    public Text sText;

    void Start()
    {
        
    }

    
    void Update()
    {
        sText.text = scoreE.ToString();
        
    }
}
