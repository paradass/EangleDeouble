using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobs.Mop
{
    public class Mop : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Water")
            {
                print("Su");
            }
        }
    }
}
