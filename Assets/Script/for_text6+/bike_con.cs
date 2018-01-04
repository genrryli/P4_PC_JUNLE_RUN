using UnityEngine;
using System.Collections;

public class bike_con : MonoBehaviour {

    public float speed = 100.0f;
    public float rotate_speed = 10f;
    public GameObject director;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        director.transform.Rotate(transform.up * moveHorizontal *rotate_speed);
        rb.AddForce(director.transform.forward*moveVertical*speed);
    }
}
