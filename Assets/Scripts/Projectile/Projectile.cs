using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Destroy(other.gameObject); // this destroys the enemy
                Destroy(gameObject); // this destroys the bullet
            }
        }
}

