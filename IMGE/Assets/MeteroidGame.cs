using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteroidGame : MonoBehaviour
{

    public GameObject meteroid;

    public bool finished = false;

    private int currentTime;

    public int startTime;

    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
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
            float speed = 2;
            float angle = 42;
            Vector3 start = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius;
            Vector3 direction = Vector3.down;
            GameObject peter = Instantiate(meteroid);
            Meteroid m = peter.GetComponent<Meteroid>();
            m.Config(speed, start, direction);
        }

        yield return 0;
    }

    IEnumerator End()
    {
        yield return 0;
    }
}
