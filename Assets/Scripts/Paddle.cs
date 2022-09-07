using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float paddleWidth;
    float paddleHeight;
    public float speed;
    string input;

    // Start is called before the first frame update
    void Start()
    {
        paddleHeight = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis(input) * speed * Time.deltaTime;

        if(transform.position.y > (GameManager.topRight.y - paddleHeight/2) && move > 0) {
            move = 0;
        }
        if(transform.position.y < (GameManager.bottomLeft.y + paddleHeight/2) && move < 0) {
            move = 0;
        }

        transform.Translate(Vector2.up * move);
    }

    public void InitPaddle(bool isRight) {
        paddleWidth = transform.localScale.x;

        if(isRight == true) {
            transform.position = new Vector2(GameManager.topRight.x - paddleWidth, 0);
            input = "RightPaddle";
        }
        else {
            transform.position = new Vector2(GameManager.bottomLeft.x + paddleWidth, 0);
            input = "LeftPaddle";
        }
    }
}
