using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] [Range(0,100)] private int damage = 7;
    [SerializeField] private float speed = 70f;

    public void Chase(Transform _target)
    {
        target = _target;
    }

    public void HitTarget()
    {
        target.gameObject.GetComponent<Enemy>().ReceiveDamage(damage);
        Destroy(gameObject);
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
    }
}
