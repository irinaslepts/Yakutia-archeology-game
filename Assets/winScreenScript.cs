using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winScreenScript : MonoBehaviour
{
    public int curLevel;
    public int curDiamonds;
    // Start is called before the first frame update
    void Start()
    {
        curDiamonds = PlayerPrefs.GetInt("diamonds");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (PlayerPrefs.HasKey("diamonds"))
        {
            PlayerPrefs.SetInt("diamonds", curDiamonds + 4);
        }
        else
        {
            PlayerPrefs.SetInt("diamonds", 4);
        }
        PlayerPrefs.SetInt("levels_completed", curLevel);
        SceneManager.LoadScene("MainScene");
        
    }
}
