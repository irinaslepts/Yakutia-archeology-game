using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class framerateController : MonoBehaviour
{
    public int framerate = 60;
    public GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = framerate;
    }
    
    /*void Awake()*/
    /*{*/
        
    /*}*/
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("timer", PlayerPrefs.GetFloat("timer") - 15);
        if (PlayerPrefs.GetFloat("timer") <= 0)
        {
            endScreen.SetActive(true);
        }
    }
}
