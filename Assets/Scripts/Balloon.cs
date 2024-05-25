using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[SelectionBase]
public class Balloon : MonoBehaviour
{
    //public GameObject avatar;
    //public GameObject prefab;
    private Animator anim;
    //[SerializeField] string _nextLevelName;
    //public float health = 0;

    public static int BalloonAlive = 0;
    bool _hasDied;
    private Sprite _deadSprite;

    // Start is called before the first frame update
    void Start()
    {
         BalloonAlive++;
        // health++;
    }


    // Update is called once per frame
    void Update()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Cactus cactus = collision.gameObject.GetComponent<Cactus>();
        if (cactus != null)
        {
            anim = GetComponent<Animator>();
            anim.Play("Srecko2");
            Destroy(gameObject, 0.2f);

            // if (collision.relativeVelocity.magnitude > health)
            // {
            //     Die();   
                   
            // }
  
       
        }

    }


    // IEnumerator Die()
    // {
        

    // //     BalloonAlive--;
    // //     health--;
    // //     if (BalloonAlive <= 0){
    // //         Debug.Log("LEVEL WON!");
    // //         SceneManager.LoadScene(_nextLevelName);
    // //     }

    //     GetComponent<SpriteRenderer>().sprite=_deadSprite;
    //     yield return new WaitForSeconds(1);
    //     gameObject.SetActive(false);
        
    //  }

}
