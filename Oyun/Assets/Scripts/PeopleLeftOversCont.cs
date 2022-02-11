using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleLeftOversCont : MonoBehaviour
{
    public GameObject[] leftovers;
    public GameObject leftover;

    public float[] whenbreaks;

    public bool canspawnleftovers;
    void Start()
    {
        StartCoroutine(LeftoverSpawn());
        canspawnleftovers = true;
    }

    
    void Update()
    {
        if (canspawnleftovers = true)
        {
            leftovertype();
            canspawnleftovers = false;
        }
        
    }
    void leftovertype()
    {
        leftover = leftovers[Random.Range(0, leftovers.Length)];
    }
    IEnumerator LeftoverSpawn()
    {
        Instantiate(leftover, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        yield return new WaitForSeconds(whenbreaks[Random.Range( 0, whenbreaks.Length)]);
        canspawnleftovers = true;
        StartCoroutine(LeftoverSpawn());
    }
}
