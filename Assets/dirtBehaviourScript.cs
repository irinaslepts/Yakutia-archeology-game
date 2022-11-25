using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static winScreenLoader;
public class dirtBehaviourScript : MonoBehaviour
{
    public GameObject stone;
    public AudioSource sfx;
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
        print("- dirt");
        sfx.Play();
        //winScreenLoader.dirtLeft--;
        Destroy(stone);
    }


}