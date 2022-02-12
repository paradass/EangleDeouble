using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mobs.Character;
public class DashFade : MonoBehaviour
{
    
    public GameObject samplePlayer;
    public float spawningtime = 0;
    public float startspawningtime;


    void Start()
    {
        clonsettings();
    }

    void clonsettings()
    {
        samplePlayer.transform.gameObject.GetComponent<Collider2D>().enabled = false;

    }

    void Update()
    {
        
        if (Player.Instance.dash == true)
        {

            if(spawningtime < startspawningtime)
            {
               GameObject ins= Instantiate(samplePlayer, new Vector2(transform.position.x, transform.position.y), transform.rotation);
                Destroy(ins,2f); 
                spawningtime = spawningtime + 1;
            }


        }
    }
}