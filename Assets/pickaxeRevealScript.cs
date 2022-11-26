using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickaxeRevealScript : MonoBehaviour
{
    public GameObject pickaxeReveal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(PlayerPrefs.GetInt("levels_completed"));
    }
    void OnMouseDown()
    {
        pickaxeReveal.SetActive(false);
    }
}
