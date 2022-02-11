using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobs.Character
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed,dashSpeed;
        private bool stunned,dashe;
        private Rigidbody2D rb;
        private Animator animator;
        Vector3 mousePosition;
        Vector2 direction;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            Move();
            Slow();
            SetPosition();
        }

        void Move()
        {
            if (!stunned)
            {
                if (Input.GetMouseButton(0))
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
                    transform.up = direction;
                    //Quaternion rotateDirection = Quaternion.LookRotation(direction);
                    //transform.rotation = Quaternion.Lerp(transform.rotation, rotateDirection, 1);
                    transform.Translate(0, speed * Time.deltaTime, 0);
                }

                if (Input.GetMouseButtonUp(0))
                {
                    dashe = true;
                    rb.velocity = transform.up* dashSpeed;
                    Invoke("ResetVelocity", 0.3f);
                }
            }
        }

        void Slow()
        {
            if (dashe)
            {
                if(rb.velocity.x > 0 && rb.velocity.y > 0)
                {
                    rb.velocity = new Vector3(rb.velocity.x - 10 * Time.deltaTime, rb.velocity.y - 10 * Time.deltaTime, 0);
                }
            }
        }
        void ResetVelocity()
        {
            dashe = false;
            rb.velocity = new Vector3(0, 0, 0);
        }

        void SetPosition()
        {
            if(transform.position.y > 5.5f)
            {
                transform.position = new Vector3(transform.position.x, -5.5f, transform.position.z);
            }
            else if(transform.position.y < -5.5f)
            {
                transform.position = new Vector3(transform.position.x, 5.5f, transform.position.z);
            }

            if (transform.position.x < -9.7f)
            {
                transform.position = new Vector3(9.7f, transform.position.y,transform.position.z);
            }
            else if (transform.position.x > 9.7f)
            {
                transform.position = new Vector3(-9.7f, transform.position.y, transform.position.z);
            }
        }

        void CancelStun()
        {
            stunned = false;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Customer")
            {
                stunned = true;
                CancelInvoke("CancelStun");
                Invoke("CancelStun", 2);
            }
        }
    }
}
