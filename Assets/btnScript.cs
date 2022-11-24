using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnScript : MonoBehaviour
{
    public void Change_lvl(string lvl){
        SceneManager.LoadScene(lvl);
    }

}
