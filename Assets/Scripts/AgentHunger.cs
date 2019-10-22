using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AgentHunger : MonoBehaviour
{
    public float hunger;
    public float DepletionRate;
    public Image healthBar;
    public GameObject foodStore;

    private void Start()
    {
        InvokeRepeating("DepleteHealth", 1f, 1f);
        StartCoroutine(GoToFoodStore());
    }

    private void DepleteHealth()
    {

        Debug.Log(hunger);
        hunger -= DepletionRate;
        healthBar.fillAmount = hunger / 100;
    }

    private IEnumerator GoToFoodStore()
    { 
        NavMeshAgent agent = gameObject.GetComponent<NavMeshAgent>();
        while (true)
        {
            if (hunger <= 80)
            {
                agent.SetDestination(foodStore.transform.position);
            }
        }
    }
}

