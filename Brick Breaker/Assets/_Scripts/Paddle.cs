using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public float velocity;
    public float boundX;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        Transform paddle = GetComponent<Transform>();
        float mouseX = Input.GetAxis("Mouse X");
        paddle.position = paddle.position + (Vector3.right * mouseX * velocity * Time.deltaTime);
        float paddleX = paddle.position.x;
        paddleX = Mathf.Clamp(paddleX, -boundX, boundX);
        paddle.position = new Vector3(paddleX, paddle.position.y, paddle.position.z);
    }
}
