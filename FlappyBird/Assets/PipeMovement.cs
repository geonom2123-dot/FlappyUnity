using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed;
    public float deadzone = -40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {

            Debug.Log("Deleted pipe");
            Destroy(gameObject);
        }
    }
}
