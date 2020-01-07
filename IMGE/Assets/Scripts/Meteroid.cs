using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteroid : MonoBehaviour
{
    private Vector3 direction;

    private Vector3 startingPoint;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = startingPoint;
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Config(float speed, Vector3 start, Vector3 direction)
    {
        this.speed = speed;
        this.startingPoint = start;
        this.direction = direction;
    }
}
