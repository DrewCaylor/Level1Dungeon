using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
    GameObject[] pauseObjects;
    GameObject[] finishObjects;
    Player player;
    Enemy enemy;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFinish");	
		hidePaused();
        hideFinished();

        //Checks to make sure MainLevel is the loaded level
		if(SceneManager.GetActiveScene().name == "MainLevel")
			player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.P) && player.playerIsDead == false)
		{
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0 && player.playerIsDead == false){
				Time.timeScale = 1;
				hidePaused();
			}
        }
            //shows finish gameobjects if player is dead and timescale = 0
		if (player != null && player.playerIsDead == true)
        {
			showFinished();
		}
        //if(enemy != null && enemy.noEnemies)
        //{
        //    showFinished();
        //}
		
    }
    public void Reload()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
    public void pauseControl()
    {
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0)
            {
				Time.timeScale = 1;
				hidePaused();
			}
	}
    //shows objects with ShowOnPause tag
	public void showPaused()
    {
		foreach(GameObject g in pauseObjects)
        {
			g.SetActive(true);
		}
	}
    //hides objects with ShowOnPause tag
	public void hidePaused()
    {
		foreach(GameObject g in pauseObjects)
        {
			g.SetActive(false);
		}
	}
    //shows objects with ShowOnFinish tag
	public void showFinished()
    {
		foreach(GameObject g in finishObjects)
        {
			g.SetActive(true);
		}
	}
    //hides objects with ShowOnFinish tag
	public void hideFinished()
    {
		foreach(GameObject g in finishObjects)
        {
			g.SetActive(false);
		}
	}
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
