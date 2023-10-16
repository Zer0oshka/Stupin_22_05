using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triger : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
 
    private void OnTriggerEnter(Collider other)
    {
        text.text = Convert.ToString(Convert.ToInt32(text.text) - 1);
    }
}
