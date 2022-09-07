using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    float ballHeight;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0,4);
        if(rand == 0) {
            direction = Vector2.one;
        }
        else if(rand == 1) {
            direction = new Vector2(-1,1);
        }
        else if(rand == 2) {
            direction = new Vector2(-1,-1);
        }
        else if(rand == 3) {
            direction = new Vector2(1,-1);
        }

        ballHeight = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if(transform.position.y > (GameManager.topRight.y - ballHeight/2) && direction.y > 0) {
            direction.y = -direction.y;
        }

        if(transform.position.y < (GameManager.bottomLeft.y + ballHeight/2) && direction.y < 0) {
            direction.y = -direction.y;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Paddle") {
            direction.x = -direction.x;
            speed += 0.5f;

            // int rand = Random.Range(0,2);
            // if(rand > 0){
            //     direction.y = -direction.y;
            // }
        }
        if(collision.tag == "ScoreLeft") {
            print("Left player scored");
            Score.leftPlayerScoreNumber++;
            GameManager.instance.GameLoop();
            Destroy(gameObject);
        }
        if(collision.tag == "ScoreRight") {
            print("Right player scored");
            Score.rightPlayerScoreNumber++;
            GameManager.instance.GameLoop();
            Destroy(gameObject);
        }

    }
}
