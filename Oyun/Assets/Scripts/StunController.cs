using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mobs.Character;
public class StunController : MonoBehaviour
{
    public GameObject text;
    public GameObject player;
    void Start()
    {

    }


    void Update()
    {
        if (Player.Instance.stunned == true)
        {
            text.SetActive(true);
            text.transform.position = new Vector2(player.transform.position.x, player.transform.position.y+1);
            text.transform.position = new Vector3(transform.position.x,transform.position.y,-3);
        }
        else if (Player.Instance.stunned == false)
        {
            text.SetActive(false);
        }

    }
}