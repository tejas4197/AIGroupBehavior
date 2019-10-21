using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentHunger : MonoBehaviour
{
    public float hunger;

    private void Start()
    {
        InvokeRepeating("DepleteHealth", 1f, 1f);
    }

    private void DepleteHealth()
    {
            Debug.Log(hunger);
            hunger -= 1;

    }
}
