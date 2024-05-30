using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    public bool isStart = false;
    
    public void SpawnBalls(int ballAmount)
    {
        if (!isStart)
        {
            isStart = true;
            for (int i = 0; i < ballAmount; i++)
            {
                Vector3 temp = new Vector3(); // Initialize temp properly
            
                temp.x = Random.Range(-1.6f, -0.8f);
                temp.y = Random.Range(54.5f, 80f);
                temp.z = Random.Range(-1.3f, 1.3f);         

                Instantiate(ballPrefab, temp, Quaternion.identity); // Use Quaternion.identity if you don't want any rotation
            }    
        }
    }
}