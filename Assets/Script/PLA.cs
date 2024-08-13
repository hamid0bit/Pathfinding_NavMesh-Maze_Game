using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;

public class PLA : MonoBehaviour
{
    public static PLA Instance;
    public Transform Player;
    private NavMeshAgent agent;
    public NavMeshPath path;
    private float elapsed = 0.0f;
    float currentTime = 0f;
    float startingTime = 5f;
    public GameObject gameFinish;

    public GameObject PopUp;

    [SerializeField] Text countdownText;

    void Start()
    {

        Time.timeScale = 1;
        if (Player == null)
        {
            Debug.LogError("Variabel Player di objek PLA belum terdefinisi atau null.");
        }
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        agent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        elapsed = 0.0f;
    }


    void Update()
    {
        //Time.timeScale = 1;
        elapsed += Time.deltaTime;
        if (elapsed > 1.0f)
        {
            elapsed -= 1.0f;
            NavMesh.CalculatePath(transform.position, Player.position, NavMesh.AllAreas, path);
        }
        for (int i = 0; i < path.corners.Length - 1; i++)
            Debug.DrawLine(path.corners[i], path.corners[i + 1], Color.red, 10.0f);



        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            currentTime = startingTime;
            Pathfinding();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            Debug.Log("Pathfinding Stop");
        }

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            stopPathfinding();
            PopUp.SetActive(false);
        }

        /*if (Input.GetKeyDown(KeyCode.X))
        {
            Pathfinding();
        }*/
    }

    public void Pathfinding()
    {
        gameObject.GetComponent<NavMeshAgent>().isStopped = false;
        UpdatePath();
        currentTime = startingTime;
        Time.timeScale = 1;
        agent.destination = Player.position;
        Debug.Log(string.Format("Pathfinding: {0}", Time.deltaTime));
    }

    void stopPathfinding()
    {
        gameObject.GetComponent<NavMeshAgent>().isStopped = true;
        //Debug.Log("Pathfinding Over!");
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Goal")
        {
            Debug.Log("Finish");
            gameFinish.SetActive(true);
            Time.timeScale = 0;
        }
    }

    /*void ShowCountdownText()
    {
        // Menampilkan teks
        countdownText.enabled = true;
    }

    void HideCountdownText()
    {
        // Menyembunyikan teks
        countdownText.enabled = false;
    }*/

    public void UpdatePath()
    {

        NavMeshAgent agent = gameObject.GetComponent<NavMeshAgent>();
        agent.SetDestination(Player.position);

        Debug.Log("Path Updated");
    }


}

