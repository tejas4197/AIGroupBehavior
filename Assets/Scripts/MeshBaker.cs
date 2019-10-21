using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshBaker : MonoBehaviour
{
    public NavMeshSurface[] surfaces;

    public void OnBakeClick()
    {
        for(int i = 0; i < surfaces.Length; i++)
        {
            surfaces[i].BuildNavMesh();
        }
    }

    public void onClearMeshClick()
    {
        for(int i=0; i<surfaces.Length; i++)
        {
            surfaces[i].RemoveData();
        }
    }
}
