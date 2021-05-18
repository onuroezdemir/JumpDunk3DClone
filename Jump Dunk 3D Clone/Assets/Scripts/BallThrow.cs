using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public List<GameObject> balls;

    public GameObject ball;
    public GameObject player;

    public GameObject ballPrefab;

    public float ballDistance = 0.1f;
    public float ballDistanceY = 0.75f;
    public float ballThrowingForce = 5f;

    private bool holdingBall = true;
    void Start()
    {
        balls[0].GetComponent<Rigidbody>().useGravity = false;
    }


    void Update()
    {
        if (holdingBall)
        {
            balls[0].GetComponent<Rigidbody>().useGravity = false;
            balls[0].transform.position = player.transform.position + player.transform.forward * ballDistance+ player.transform.up*ballDistanceY;

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                balls[0].GetComponent<Rigidbody>().useGravity = true;
                balls[0].GetComponent<Rigidbody>().AddForce(new Vector3(0,1,1) * ballThrowingForce);
                balls.Remove(balls[0]);
                StartCoroutine(CreateNewBall());
            }
        }

    }

    public IEnumerator CreateNewBall()
    {
        
            yield return new WaitForSeconds(0.5f);
            GameObject newBall =  Instantiate(ballPrefab, player.transform.position + player.transform.forward * ballDistance + player.transform.up * ballDistanceY, player.transform.rotation);
            balls.Add(newBall);
            holdingBall = true;
        
    }


}
