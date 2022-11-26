using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskotScript : MonoBehaviour
{
    public GameObject maskotScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        PlayerPrefs.SetInt("tutorialCompleted", 1);
        maskotScript.SetActive(false);
    }
}
