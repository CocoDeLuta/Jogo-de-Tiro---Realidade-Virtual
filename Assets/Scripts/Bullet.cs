using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            float RandomX = Random.Range(-24, 24);
            float RandomZ = Random.Range(-24, 24);
            float RandomRotation = Random.Range(0, 360);
            Instantiate(other.gameObject,
                        new Vector3(RandomX, 1, RandomZ),
                        Quaternion.Euler(0, RandomRotation, 0));
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
