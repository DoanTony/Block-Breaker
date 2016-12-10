using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
    private Player the_Player;
    private AudioSource sound;
    
    
    void Start()
    {
        sound = gameObject.GetComponent<AudioSource>();
        the_Player = GameObject.FindObjectOfType<Player>();
       
    }
    void OnTriggerEnter2D (Collider2D collide)
    {
        sound.Play();
        the_Player.LoseLife();    
    }
}
