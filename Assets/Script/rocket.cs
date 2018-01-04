using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class rocket : MonoBehaviour {

    public Rigidbody Item;
    public Transform StartLocation;
    public AudioClip rocket_s;

    private Rigidbody InstanceItem;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.F)||transform.parent.root.tag=="com")
        {
            InstanceItem = Instantiate(Item, StartLocation.position, StartLocation.rotation) as Rigidbody;
            InstanceItem.name = transform.parent.parent.name+"_";
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(rocket_s, StartLocation.position, 1);
        }

    }
}
