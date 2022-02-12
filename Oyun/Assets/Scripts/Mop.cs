using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mobs.Character;
namespace Mobs.Mop
{
    public class Mop : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Water" && Player.Instance.dash)
            {
                Player.Instance.score += 10;
                Destroy(collision.gameObject,0.1f);
            }
            else if (collision.gameObject.tag == "Water" && !Player.Instance.dash)
            {
                Player.Instance.Stun();
                Player.Instance.Slip();
            }
        }
    }
}
