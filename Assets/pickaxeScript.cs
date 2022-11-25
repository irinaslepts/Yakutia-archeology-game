using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickaxeScript : MonoBehaviour
{
    public GameObject valueSaver;
    private SavedValues savedValues;
    // Start is called before the first frame update
    public void setValues()
    {
        savedValues = valueSaver.GetComponent<SavedValues>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        setValues();
        print("got pickaxe");
        savedValues.pickaxeOwned = true;
    }
}
