using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteroid : MonoBehaviour
{
    private Vector3 direction;


    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        StartCoroutine(Ded());
    }

    public void Config(float speed, Vector3 direction, float size)
    {
        gameObject.transform.localScale *= size;
        this.speed = speed;
        this.direction = direction;
    }

    IEnumerator Ded()
    {
        yield return new WaitForSeconds(20/ speed);
        Destroy(gameObject);
        
    }
}
