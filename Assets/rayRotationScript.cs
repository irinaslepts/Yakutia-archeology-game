using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayRotationScript : MonoBehaviour
{
    public float rotation;
    public int rotationTimer = 5000;
    public GameObject gameObject;
    public Vector3 q = new Vector3(0.3f, 0.3f, 0);
    public int phase = 0;
    public bool isIncreasing = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, rotation, Space.Self);
        gameObject.transform.localScale += q;
        if (isIncreasing) 
        {
            phase++;
        }
        else
        {
            phase--;
        }
        if (phase == 20)
        {
            isIncreasing = false;
            q = -q;
            phase--;
        }
        if (phase == -1)
        {
            phase++;
            isIncreasing = true;
            q = -q;
        }
            
    }
}
