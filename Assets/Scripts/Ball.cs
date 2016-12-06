using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Paddle Paddle;


    private Vector3 PaddleToBallVector;
    private AudioSource HitSound;

    // Static Variables to test autoplay to find Bugs
    public static bool hasStarted; 
    public static Rigidbody2D BallRigidBody;

	void Start () {
        HitSound = GetComponent<AudioSource>();
        Paddle = GameObject.FindObjectOfType<Paddle>();
        BallRigidBody = GetComponent<Rigidbody2D>();
        PaddleToBallVector = this.transform.position - Paddle.transform.position;
	}

	void Update () {
        if(!hasStarted) // Check if the ball has been launched 
        {
            this.transform.position = Paddle.transform.position + PaddleToBallVector;
            // Launch the ball
            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                BallRigidBody.velocity = new Vector2(2f, 10f);
            }
        }
	}

    public void ResetBall()
    {
        Vector3 PaddlePosition = new Vector3(Paddle.transform.position.x,Paddle.transform.position.y + 10f,0f);
        gameObject.transform.position = PaddlePosition;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 TweakingBall = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));
        if(hasStarted)
        {
            BallRigidBody.velocity += TweakingBall;
            HitSound.Play();
        }       
    }

}
