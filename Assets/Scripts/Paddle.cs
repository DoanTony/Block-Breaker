using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    public bool Autoplay;

    private Ball ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
      
        if(!Autoplay)
        {
            MouseHandler();
        }
        else
        {
            AutoPlaying();
        }

	}

    private void MouseHandler()
    {
        Vector3 paddlePostion = new Vector3(0.5f, this.transform.position.y, 0f);
        float mouseXPosition = Input.mousePosition.x / Screen.width * 16;
        paddlePostion.x = Mathf.Clamp(mouseXPosition, 1.0f, 18.2f);
        this.transform.position = paddlePostion;
    }

    private void AutoPlaying()
    {
        Vector3 paddlePostion = new Vector3(0.5f, this.transform.position.y, 0f);
        Vector3 ballPosition = ball.transform.position;

        if (!Ball.hasStarted)
        {
            Ball.BallRigidBody.velocity = new Vector2(2f, 10f);
        }
        
        Ball.hasStarted = true;
        paddlePostion.x = Mathf.Clamp(ballPosition.x, 1.0f, 18.2f);
        this.transform.position = paddlePostion;
    }
}
