using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winScreenScript : MonoBehaviour
{
    public int curLevel;
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
        PlayerPrefs.SetInt("levels_completed", curLevel);
        SceneManager.LoadScene("MainScene");
        
    }
}
