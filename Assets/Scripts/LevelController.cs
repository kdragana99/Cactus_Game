using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SelectionBase]
public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    private static int _nextLevelIndex = 1;
    private Balloon[] _balloon;
    public float BalloonAlive = 0;

    void Start()
    {
        BalloonAlive++;
    }
    void OnEnable()
    {
        _balloon = FindObjectsOfType<Balloon>();
    }

    void Update()
    {
        // foreach(Balloon balloon in _balloon)
        // {
        //     BalloonAlive--;
        //     if(balloon != null)
        //     {
        //         return;
        //     }
        //     if (BalloonAlive <= 0){
        //         Debug.Log("LEVEL WON!");
        //         SceneManager.LoadScene(_nextLevelName);
        //     }   
        // }
       
       if(BalloonAreAllDead())
       {
            GoToNextLevel();
       }
    }

    private void GoToNextLevel()
    {
        SceneManager.LoadScene(_nextLevelName);
    }

    private bool BalloonAreAllDead()
    {
        foreach(Balloon balloon in _balloon)
        {
            if(balloon != null)
            {
                return false;
            }
            
        }
        return true;
    }
}
