using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Ball ball;
    public Paddle paddle;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null) {
            instance = this;
        }
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Paddle paddle1 = Instantiate(paddle);
        Paddle paddle2 = Instantiate(paddle);

        Instantiate(ball);

        paddle1.InitPaddle(true);
        paddle2.InitPaddle(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameLoop() {
        Invoke("InstantiateBall",1);
    }

    void InstantiateBall() {
        Instantiate(ball);
    }
}
