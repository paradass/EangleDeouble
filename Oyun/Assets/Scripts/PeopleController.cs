using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleController : MonoBehaviour
{
    public GameObject targetObject;
    public Transform position;
    public GameObject[] unknownpeople;
    public GameObject unknownman;
    public float[] distancey;
    public float[] distancex;
    public float randomnumbe;
    public float[] maxAndminValue;

    public float[] rotasiations1;
    public float[] rotasiations2;
    public float[] rotasiations3;
    public float[] rotasiations4;
    
    public Quaternion rotatiaton;

    public bool canspawnnow;

    public float positionspawnnum;
    
    void Start()
    {
        
        canspawnnow = true;
        StartCoroutine(spawningthings());
    }

    
    void Update()
    {

        if (canspawnnow == true)
        {
            spawnObject();
            SpawnPositions();
            randownRot();
            canspawnnow = false;
        }
           



        
        
    }
    void SpawnPositions()
    {
        randomnumbe =Random.Range(1, 5);
        if (randomnumbe == 1)
        {
            position.position = new Vector2(targetObject.gameObject.transform.position.x + distancex[ Random.Range(0, distancex.Length)], targetObject.gameObject.transform.position.y + 6);
            positionspawnnum = 1;
        }
        else if (randomnumbe == 2)
        {
            position.position = new Vector2(targetObject.gameObject.transform.position.x + -11, targetObject.gameObject.transform.position.y + distancey[ Random.Range(0,distancey.Length)]);
            positionspawnnum = 2;
        }
        else if(randomnumbe == 3)
        {
            position.position = new Vector2(targetObject.gameObject.transform.position.x + 11, targetObject.gameObject.transform.position.y + distancey[Random.Range(0, distancey.Length)]);
            positionspawnnum = 3;
        }
        else if(randomnumbe == 4)
        {
            position.position = new Vector2(targetObject.gameObject.transform.position.x + distancex[Random.Range(0, distancex.Length)], targetObject.gameObject.transform.position.y + -6);
            positionspawnnum =4;
        }
        
    }
    void spawnObject()
    {
        unknownman = unknownpeople[Random.Range(0, unknownpeople.Length)];
    }
    void randownRot()
    {
        if(positionspawnnum == 1)
        {
            rotatiaton = Quaternion.Euler(0, 0, rotasiations1[Random.Range(0, rotasiations1.Length)]);
        }
        else if (positionspawnnum == 2)
        {
            rotatiaton = Quaternion.Euler(0, 0, rotasiations2[Random.Range(0, rotasiations2.Length)]);
        }
        else if (positionspawnnum == 3)
        {
            rotatiaton = Quaternion.Euler(0, 0, rotasiations3[Random.Range(0, rotasiations3.Length)]);
        }
        else if (positionspawnnum == 4)
        {
            rotatiaton = Quaternion.Euler(0, 0, rotasiations4[Random.Range(0, rotasiations4.Length)]);
        }

    }
    IEnumerator spawningthings()
    {

        yield return new WaitForSeconds(maxAndminValue[Random.Range(0,maxAndminValue.Length)]);
            
            Instantiate(unknownman, position.position, rotatiaton);
            canspawnnow = true;
            StartCoroutine(spawningthings());
            

    }
}
