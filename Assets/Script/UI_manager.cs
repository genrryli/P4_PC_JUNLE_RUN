using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_manager : MonoBehaviour {

    public GameObject player;
    public GameObject start_page;
    public GameObject single_mode;
    public GameObject UI_Playing;
    public GameObject UI_finish;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (game_manager.gm.gamestate == game_manager.game_state.finish)
        {
            UI_Playing.SetActive(false);
            UI_finish.SetActive(true);
        }
	}

    public void play_jungle_day()
    {
        SceneManager.LoadScene("jungle_day");
    }

    public void play_jungle_night()
    {
        SceneManager.LoadScene("jungle_night");
    }

    public void go_to_single_mode()
    {
        start_page.SetActive(false);
        player.SetActive(false);
        single_mode.SetActive(true);        
    }

    public void go_to_start_page()
    {
        single_mode.SetActive(false);
        start_page.SetActive(true);
        player.SetActive(true);   
    }

    public void play_again()
    {
        Scene scene = SceneManager.GetActiveScene();
        string name_ = scene.name;
        SceneManager.LoadScene(name_);
    }

    public void back_to_menue()
    {
        SceneManager.LoadScene("start");
    }

}
