using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
   public GameObject target;

    void Reset()
    {
        //Output the message to the Console
        Debug.Log("Reset");
        if (!target)
            target = GameObject.FindWithTag("Player");
    }
}
