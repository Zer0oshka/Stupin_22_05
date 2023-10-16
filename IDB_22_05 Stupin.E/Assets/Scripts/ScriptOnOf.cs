using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOnOf : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Object3D;
    // Update is called once per frame
    private void OnMouseDown()
    {
        Object3D.SetActive(!Object3D.activeSelf); 
    }
}
