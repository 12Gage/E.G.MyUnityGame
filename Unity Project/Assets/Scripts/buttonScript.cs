using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour {

    public string LeveltoLoad;

    public void loadLevel()
    {
        SceneManager.LoadScene(LeveltoLoad);
    }

    public void quit()
    {
        Application.Quit();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
