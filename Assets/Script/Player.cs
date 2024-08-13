using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    
    public Camera cam;
    public NavMeshAgent agent;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Debug.Log(string.Format("Waktu Eksekusi: {0}", Time.deltaTime));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)) {
                agent.SetDestination(hit.point);
                
            //Debug.Log("coordinate" + hit);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
