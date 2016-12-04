using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	

    public void LoadLevel(string level_name)
    {
        Application.LoadLevel(level_name);
    }

    public void BlockDestroyed()
    {
        if(Blocks.breakableBlockCount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
