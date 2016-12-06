using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
    private Player the_Player;
    
    
    void Start()
    {
        the_Player = GameObject.FindObjectOfType<Player>();
       
    }
    void OnTriggerEnter2D (Collider2D collide)
    {
        Ball.hasStarted = false;
        the_Player.LoseLife();    
    }
}
