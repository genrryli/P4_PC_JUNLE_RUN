using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button_con : MonoBehaviour {

    public Button[] button;
    public GameObject[] weapons;
    public AudioClip button_switch;
    public AudioClip button_comfirm;

    private int seleted=0;
    private bool weapons_ready;
    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        if (button[seleted].IsActive() == false)
        {
            if (seleted >= button.Length - 1) { seleted = 0; }
            else { seleted += 1; }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (seleted >= button.Length - 1) { seleted = 0; }
            else { seleted += 1; }
            GetComponent<AudioSource>().PlayOneShot(button_switch,50);
        }

        weapons_on();
        button[seleted].Select();
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (button[seleted].IsActive() == true && weapons_ready == false)
            {
                button[seleted].onClick.Invoke();
                GetComponent<AudioSource>().PlayOneShot(button_comfirm,2);
                
            }
        }

    }

    void weapons_on()
    {
        for(int i = 0; i <= weapons.Length - 1; i++)
        {
            if (weapons[i].active == true) { weapons_ready = true;break; }
            else { weapons_ready = false; }
        }
    }

}
