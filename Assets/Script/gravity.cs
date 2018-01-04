using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

    public GameObject Item;
    public Transform StartLocation;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.F) || transform.parent.root.tag == "com")
        {
            GameObject go= Instantiate(Item, StartLocation.position, StartLocation.rotation)as GameObject;
            go.name = transform.parent.parent.name + "_";
            gameObject.SetActive(false);
        }
    }
}
