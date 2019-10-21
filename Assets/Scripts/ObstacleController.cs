using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObstacleController : MonoBehaviour
{
    public NavMeshSurface surface;
    public GameObject[] obstacle;

    private void Start()
    {
        //obstacle.SetActive(false);
       // obstacle = GameObject.FindGameObjectsWithTag("Obstacle");
    }

    private void Update()
    {
        ActivateObstacle();
    }


    private void ActivateObstacle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clic");
            for (int i = 0; i < obstacle.Length; i++)
            {
                if (obstacle[i].activeSelf == false)
                {
                    surface.BuildNavMesh();
                    obstacle[i].SetActive(true);
                }
                else
                {
                    obstacle[i].SetActive(false);
                }
            }
        }
    }
}
