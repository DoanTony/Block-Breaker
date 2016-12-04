using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour {

    private int HitCounter;
    private LevelManager levelManager;
    private bool isBreakable;

    public static int breakableBlockCount;
    public Sprite[] mySprites;


    void Start()
    {
        isBreakable = (this.tag == "Breakable");
        if(isBreakable)
        {
            breakableBlockCount++;
        }
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        int BlockHp = mySprites.Length + 1;
        ++HitCounter;
        if (HitCounter >= BlockHp)
        {
            breakableBlockCount--;
            Destroy(gameObject);
        }
        else
        {
            LoadSprite();
        }
    }

    void LoadSprite()
    {
        if(mySprites[HitCounter - 1])
        {
              this.GetComponent<SpriteRenderer>().sprite = mySprites[HitCounter -1];
        }
    }
}
