using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn1 : MonoBehaviour
{
    public int level;
    public SpriteRenderer spriteRenderer;
    public Sprite completionSprite;
    public Sprite unavailableSprite;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("levels_completed"));
        if (PlayerPrefs.GetInt("levels_completed") >= level)
        {
            print(level.ToString()+" completed");
            print("level " + level.ToString());
            spriteRenderer.sprite = completionSprite; 
        }
        else if (PlayerPrefs.GetInt("levels_completed") + 1 < level)
        {
            print(level.ToString()+" unavailable");
            spriteRenderer.sprite = unavailableSprite;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown(){
        if (PlayerPrefs.GetInt("levels_completed") + 1 == level)
        {
            SceneManager.LoadScene("level" + level.ToString());
        }
        
        
    }

}
