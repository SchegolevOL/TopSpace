using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  // вставьте следующую строку ДО начала класса BulletController
    [RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{

    [SerializeField] private int damage;
    [SerializeField, Range(1, 10)] int startPower;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 10f);
        rb.velocity = transform.forward * startPower * 100f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Health obj = collision.gameObject.GetComponentInParent<Health>();

        if (obj) 
        {
            obj.GetDamage(damage);
        }
        Destroy(gameObject);
    }


}
