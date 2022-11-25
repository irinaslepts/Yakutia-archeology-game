using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickaxeReveal : MonoBehaviour
{
    public GameObject pickaxeGiver;
    public GameObject shovelGiver;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("levels_completed"))
        {
            if (PlayerPrefs.GetInt("levels_completed") == 1)
            {
                pickaxeGiver.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("levels_completed") == 2)
            {
                shovelGiver.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
