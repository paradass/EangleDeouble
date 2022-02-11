using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMovement : MonoBehaviour
{
    public float speed;
    private Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    
    void Update()
    {
        transform.Translate(1*Time.deltaTime*speed, 0, 0);

    }

}
