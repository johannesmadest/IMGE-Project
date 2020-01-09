using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteroidGame : MonoBehaviour
{

    public GameObject meteroid;

    public GameObject player;
    
    public bool finished = false;

    private int currentTime =10;

    public int startTime;

    public float radius;

    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            Debug.Log("f pressed");
            StartCoroutine(Spawn());
        }

        if (Input.GetKeyDown("s"))
        {
            Debug.Log("s pressed");
            finished = true;
        }
        
        if (currentTime <= 0)
        {
            finished = true;
            StartCoroutine(End());
        }
    }

    IEnumerator Spawn()
    {
        while (!finished)
        {
            float factor = Random.Range(1f, 5f);
            float speed = 2 * factor;
            float size = 5 / factor;
            float angle = Random.Range(0f, 90f);
            Vector3 start = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle)*0.8f, 0) * radius;
            float angle2 = angle + Random.Range(-45f, 45f) ;
            Vector3 direction =(player.transform.position + new Vector3(Random.Range(-10f, 10f),Random.Range(-10f, 10f),0) )- start;
             
            
            GameObject peter = Instantiate(meteroid, start, Quaternion.identity);
            Meteroid m = peter.GetComponent<Meteroid>();
            m.Config(speed, direction, size);
            yield return new WaitForSeconds(delay);
        }

        yield return 0;
    }

    IEnumerator End()
    {
        
        yield return 0;
    }
}
