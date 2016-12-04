using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {


    public LevelManager Level_Manager;

    void OnTriggerEnter2D (Collider2D collide)
    {
        Level_Manager.LoadLevel("Game_Over");
    }
}
