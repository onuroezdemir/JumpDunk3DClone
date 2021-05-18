using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollect : MonoBehaviour
{


    private void OnEnable()
    {
        EventManager.OnBallCollected.AddListener(CollectBall);
    }

    private void OnDisable()
    {
        EventManager.OnBallCollected.RemoveListener(CollectBall);
    }

    public void CollectBall()
    {

    }

}
