using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRoads : MonoBehaviour
{
    public Transform[] points;
    public GameObject roadPrefab;
    public GameObject waterPrefab;
    public GameObject enemyPrefab;
    public GameObject coinPrefab;

    public float startTime;
    public float wavesTIme;

    private void Update()
    {
        startTime -= Time.fixedDeltaTime;
        if (startTime <= 0)
        {
            int randomOut = Random.Range(0, points.Length);
            bool check = false;
            for(int i=0; i<points.Length; i++)
            {
                if(i == randomOut)
                {
                    Instantiate(waterPrefab, points[i].position, Quaternion.identity);
                }
                else
                {
                    int enemyRandom = Random.Range(0, 3);
                    if(enemyRandom == 1 && check == false)
                    {
                        Instantiate(enemyPrefab, points[i].position, Quaternion.identity);
                        check = true;
                    }
                    else if(enemyRandom == 2)
                    {
                        Instantiate(coinPrefab, points[i].position, Quaternion.identity);
                    }
                    Instantiate(roadPrefab, points[i].position, Quaternion.identity);
                }
            }

            startTime = wavesTIme;
        }
    }

}
