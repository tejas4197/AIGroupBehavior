using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStoreController : MonoBehaviour
{

    public GameObject agent;
    private AgentHunger agentHunger;
    private void Start()
    {
        agentHunger = agent.GetComponent<AgentHunger>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLISON");
        agentHunger.isDepleteHunger = false;
        StartCoroutine(agentHunger.IncreaseHunger());
    }
    
}
