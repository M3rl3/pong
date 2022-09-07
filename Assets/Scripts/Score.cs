using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text rightPlayerScore;
    public Text leftPlayerScore;
    public static int rightPlayerScoreNumber;
    public static int leftPlayerScoreNumber;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rightPlayerScore.text = rightPlayerScoreNumber.ToString();
        leftPlayerScore.text = leftPlayerScoreNumber.ToString();
    }
}
