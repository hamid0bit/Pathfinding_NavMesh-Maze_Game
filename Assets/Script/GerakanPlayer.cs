using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanPlayer : MonoBehaviour
{
    Rigidbody myRigidbody;

    [SerializeField] float moveSpeed;

    float hInput;
    float vInput;

    // Start is called before the first frame update
    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = SimpleInput.GetAxis("Horizontal") * moveSpeed;
        vInput = SimpleInput.GetAxis("Vertical") * moveSpeed;

        float movX = SimpleInput.GetAxis("Horizontal");
        float movY = SimpleInput.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector3.zero;
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        myRigidbody.AddForce(hInput * Time.fixedDeltaTime, 0f, vInput * Time.fixedDeltaTime);
    }

}
