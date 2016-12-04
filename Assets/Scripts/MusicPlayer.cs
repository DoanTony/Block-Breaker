using UnityEngine;
using System.Collections;


public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;
    string CurrentScene;

    void Awake ()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
	// Use this for initialization
	void Start () {
        
       
	}

    void FixedUpdate()
    {
        CurrentScene = Application.loadedLevelName;
        if(CurrentScene == "Level_01")
        {
 
        }
    }
	
	// Update is called once per frame
	void Update () {
	   
	}
}
