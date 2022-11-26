using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class diamondCounterScript : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public GameObject tutorial;
    int diamonds;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("timer"))
        {
            PlayerPrefs.SetFloat("timer", 3*60*1000);
        }
        if (PlayerPrefs.GetInt("tutorialCompleted") == 0)
        {
            tutorial.SetActive(true);
        }
        diamonds = PlayerPrefs.GetInt("diamonds");
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "x" + diamonds.ToString();
    }
}
