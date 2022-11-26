using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class winScript : MonoBehaviour
{

    public GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        winScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onMouseDown()
    {
        winScreen.SetActive(true);
    }
}
