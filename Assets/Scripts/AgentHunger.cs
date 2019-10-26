using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AgentHunger : MonoBehaviour
{
    public float hunger;
    public float DepletionRate;
    public float hungerThreshold;
    public Image healthBar;
    public GameObject foodStore;

    public bool isDepleteHunger = true;
    public bool supressLogs = true;

    private void Start()
    {
        InvokeRepeating("DepleteHealth", 1f, 1f);
        StartCoroutine(GoToFoodStore());
    }

    private void DepleteHealth()
    {
        if (isDepleteHunger == true)
        {
            if(supressLogs == false)
            {
                Debug.Log("agent hunger is " + hunger);
            }
            hunger -= DepletionRate;
            healthBar.fillAmount = hunger / 100;
        }

    }

    private IEnumerator GoToFoodStore()
    { 
        NavMeshAgent agent = gameObject.GetComponent<NavMeshAgent>();
        while (isDepleteHunger == true)
        {
           
            if (hunger <= hungerThreshold)
            {
                agent.SetDestination(foodStore.transform.position);
            }
            yield return new WaitForSeconds(1f);
        }
    }

    public IEnumerator IncreaseHunger()
    {
        yield return new WaitForSeconds(1.5f);
        healthBar.fillAmount = 1f;
    }
    

}

