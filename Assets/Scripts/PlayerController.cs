using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private float horizontalInput;
    private float centerToEdge;

    [SerializeField] private GameObject projectile; 

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        centerToEdge = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForInput();
        Move();
        FeedTheAnimals();
    }

    private void CheckForInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if(transform.position.x > centerToEdge)
        {
            transform.position = new Vector3(centerToEdge, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -centerToEdge)
        {
            transform.position = new Vector3(-centerToEdge, transform.position.y, transform.position.z);
        }
    }

    private void FeedTheAnimals()
    {
       // if(Input.GetKeyDown(KeyCode.Space))
       // {
       //     Instantiate(projectile, transform.position, projectile.transform.rotation);
       // }

    }
}
