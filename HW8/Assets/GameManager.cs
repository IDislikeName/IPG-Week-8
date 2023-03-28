using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance != this && instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public int P1score;
    public int P2score;
    public BallDB ballDB;
    public float time = 0f;
    public int ballnum = 0;
    public TMP_Text p1score;
    public TMP_Text p2score;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBall(2f));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballnum == 0||time >= 8f)
        {
            time = 0;
            StartCoroutine( SpawnBall(2f));
        }
        else
        {
            time += Time.deltaTime;
        }
        p1score.text = ""+P1score;
        p2score.text = "" + P2score;
    }
    IEnumerator SpawnBall(float waitTime)
    {
        GameObject ball = Instantiate(ballDB.ballList[Random.Range(0, ballDB.ballList.Length)]);
        ball.transform.position = new Vector2(0, 0);
        ballnum++;
        yield return new WaitForSeconds(waitTime);
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(20, -15)*3);
        }
        else
        {
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(-20, -15)*3);
        }
    }
}
