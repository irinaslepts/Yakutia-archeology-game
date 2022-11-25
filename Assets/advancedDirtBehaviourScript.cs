using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class advancedDirtBehaviourScript : MonoBehaviour
{
    public GameObject stone;
    public GameObject valueSaver;
    private SavedValues savedValues;
    // Start is called before the first frame update
    public void setValues()
    {
        savedValues = valueSaver.GetComponent<SavedValues>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        setValues();
        if (savedValues.pickaxeOwned == true)
        {    
            print("- dirt");
            //winScreenLoader.dirtLeft--;
            Destroy(stone);
        }
    }


}