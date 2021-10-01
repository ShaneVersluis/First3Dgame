using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public string nextSceneName;
    public bool lastLevel;

    //gets called when collidor hits players collidorbox
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //is this the last level? return to menu
            if(lastLevel == true)
            {
                SceneManager.LoadScene(0);

            }
            //Else load the next level
            else
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }

}
