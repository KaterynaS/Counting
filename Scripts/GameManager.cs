using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    GameState gameState;
    //gets N = number of balloons on level
    public int N;

    //array of balloon prefabs to choose from
    public GameObject[] BalloonPrefabs;

    //array of ballons created on the screen

    public GameObject[] SpawnPoints;
    public Color[] colorsForBalloons;

    public GameObject EndLevelPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.GetInstance();
        gameState.setGameNumber(N);
        //BalloonsToBlow = new GameObject[N];
        CreateTheBalloons();
        EndLevelPanel.SetActive(false);
    }


    //create array of balloons with corresponding numbers from 1 to N
    void CreateTheBalloons()
    {
        for (int f = 1; f <= gameState.getGameNumber(); f++)
        {
            
            ////Todo change balloon sizes

            Color clr = colorsForBalloons[Random.Range(0, colorsForBalloons.Length - 1)];
            //private Baloon(int num, Color clr, int shape, GameObject spawnP)
            Baloon baloon = new Baloon(f, clr, BalloonPrefabs[Random.Range(0, BalloonPrefabs.Length - 1)]);
            gameState.addObjectToArrayToPosition(baloon, f - 1);

            float x = Random.Range(SpawnPoints[0].transform.position.x,
                SpawnPoints[SpawnPoints.Length-1].transform.position.x);

            float y = Random.Range(SpawnPoints[0].transform.position.y,
                SpawnPoints[SpawnPoints.Length - 1].transform.position.y);

            Vector3 newSpawnPoint = new Vector3(x,y,0);

            Instantiate(baloon.getBaloonGameObj(), newSpawnPoint, Quaternion.identity);

        }
    }


    public void endLevel()
    {
        Debug.Log("Congrats!");
        EndLevelPanel.SetActive(true);
    }

}
