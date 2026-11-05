using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axis : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + horizontal * speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
