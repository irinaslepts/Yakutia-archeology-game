using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickaxeRevealScript : MonoBehaviour
{
    public GameObject pickaxeReveal;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("levels_completed"))
        {
            if (PlayerPrefs.GetInt("levels_completed") == 1)
            {
                pickaxeReveal.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
