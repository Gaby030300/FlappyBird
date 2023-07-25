using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 2.0f;
    private float initialTime = 0f;
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float height;
    [SerializeField] private float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = transform.position + new Vector3 (0, 0, 0);
        Destroy(newObstacle, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        if(initialTime > maxTime) 
        {
            GameObject newObstacle = Instantiate(obstacle);
            newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObstacle, timeToDestroy);
            initialTime = 0f;
        }
        else
        {
            initialTime += Time.deltaTime;
        }
    }
}
