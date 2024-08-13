using UnityEngine;
using UnityEngine.AI;

public class ShowGoldenPath : MonoBehaviour
{
    public Transform target;
    private NavMeshPath path;
    private float elapsed = 0.0f;
    void Start()
    {
        path = new NavMeshPath();
        elapsed = 0.0f;
    }

    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed > 1.0f)
        {
            elapsed -= 1.0f;
            bool pathFound = NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
            if (pathFound)
            {
                Debug.Log("Path found!");
            }
            else
            {
                Debug.LogWarning("Path not found!");
            }
        }

        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            Debug.DrawLine(path.corners[i], path.corners[i + 1], Color.red, 100.0f);
        }
    }
}