using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {



    private Vector3 PaddleToBallVector;
    private AudioSource HitSound;

    public static Rigidbody2D BallRigidBody;

	void Start () {
        HitSound = GetComponent<AudioSource>();
        BallRigidBody = GetComponent<Rigidbody2D>();
	}

    public void LaunchBall()
    {
        if (Application.loadedLevelName == "Level_01")
        {
            BallRigidBody.gravityScale = 7;
        }
        else
        {
            BallRigidBody.gravityScale = 8;
        }
    }

    public void ResetBall()
    {
        BallRigidBody.gravityScale = 0;
        BallRigidBody.velocity = Vector2.zero;
        GameObject resetposition = GameObject.FindGameObjectWithTag("Reset");
        gameObject.transform.position = resetposition.transform.position;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        BallRigidBody.gravityScale = 1;   
        Vector2 TweakingBall = new Vector2(Random.Range(0f, 0.8f), Random.Range(0f, 0.8f));
        BallRigidBody.velocity += TweakingBall;
        HitSound.Play();
        if(collision.gameObject.GetComponent<LoseCollider>())
        {
            ResetBall();
        }

    }

}
