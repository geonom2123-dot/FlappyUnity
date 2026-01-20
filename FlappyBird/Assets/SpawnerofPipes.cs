using System.Threading;
using UnityEngine;

public class SpawnerofPipes : MonoBehaviour
{
    private float timer;
    public GameObject Pipe;
    public float spawnrate=4;
    public float heightoffset = 6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            createPipe();
            timer = 0;
        }

        
    }
    void createPipe()
    {
        float lowest = transform.position.y-heightoffset;
        float heigest= transform.position.y+heightoffset;
        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowest,heigest),0), transform.rotation);


    }
}
