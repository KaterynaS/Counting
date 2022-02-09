using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonMoves : MonoBehaviour
{
    private float timeBtwRandomMoves;
    public float startTimeBtwRandomMoves;

    Vector3 pointB = new Vector3(0, 0, 0);

    public float speedIdle = 0.3f;


    // Update is called once per frame
    void Update()
    {
        moveBalloon();
    }


    void moveBalloon()
    {
        //ToDo every second move is toward the spawn point or close
        if (timeBtwRandomMoves >= 0)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                pointB,
                speedIdle * Time.deltaTime);

            timeBtwRandomMoves -= Time.deltaTime;

        }
        else
        {
            timeBtwRandomMoves = startTimeBtwRandomMoves;
            pointB = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        }
    }
}
