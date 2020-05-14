using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xrange = 10f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Fired");
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
        if (transform.position.x < -xrange)
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        
        if (transform.position.x > xrange)
            transform.position = new Vector3(10, transform.position.y, transform.position.z);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
    }
}
