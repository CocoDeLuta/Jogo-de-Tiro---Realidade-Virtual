using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float x, z;
    [SerializeField] private float moveSpeed = 2f, rotationSpeed = 2f;
    [SerializeField] private GameObject bulletSpawn, bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Movement()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        transform.Rotate(0, x * rotationSpeed, 0);
        transform.Translate(0, 0, z * moveSpeed * Time.deltaTime);
    }

    void Fire()
    {
        Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
    }
}
