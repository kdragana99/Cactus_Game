using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] string _nextLevelName;
    public float BalloonAlive = 0;
    private Balloon balloon;
    private object collision;
    public float health = 0;

    void Start()
    {
        BalloonAlive++;
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
           
            if (collision.relativeVelocity.magnitude > health)
             {
                 BalloonDie();   
                   
             }


        }
    }
    void BalloonDie()
    {
         BalloonAlive--;
        if (BalloonAlive <= 0){
            Debug.Log("LEVEL WON!");
            SceneManager.LoadScene(_nextLevelName);
        }
        
        
    }
}
