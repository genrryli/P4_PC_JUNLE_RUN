using UnityEngine;
using System.Collections;

public class oil_suffer : MonoBehaviour {

    private float timer;
    private float turn_speed;
	// Use this for initialization
	void Start () {
        if (transform.parent.root.tag == "Player")
        {
            turn_speed = GameObject.Find(transform.parent.parent.name).GetComponent<GoAndTurn>().turn_speed;
        }
           
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (transform.parent.root.tag == "com")
        {
            GameObject.Find(transform.parent.parent.name).GetComponent<NavMeshAgent>().acceleration = 0 ;
            if (timer >= 3) { timer = 0; gameObject.SetActive(false); }
        }


        if (transform.parent.root.tag == "Player")
        {
            GameObject.Find(transform.parent.parent.name).GetComponent<GoAndTurn>().turn_speed = 10;
            if (timer >= 3)
            {
                timer = 0;
                GameObject.Find(transform.parent.parent.name).GetComponent<GoAndTurn>().turn_speed = turn_speed;
                gameObject.SetActive(false);
            }
        }
            
        

	}
}
