using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    void Update()
    {
        BlockDestroyed();
    }
	

    public void LoadLevel(string level_name)
    {
        Application.LoadLevel(level_name);
    }

    public void BlockDestroyed()
    {
        if(Blocks.breakableBlockCount <= 0 && !(Application.loadedLevelName == "Start"))
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
