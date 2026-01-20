using UnityEngine;

public class Bird : MonoBehaviour
{

    public Rigidbody2D rigibody_2d;
    public float birdparameter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public LogicManager logicmanager;
    public bool alive = true;
    void Start()
    {
        logicmanager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<=-27 || transform.position.y>=19 || transform.position.y<=-15.8){
            logicmanager.gameover();
            alive = false;

        }

        if (Input.GetKeyDown(KeyCode.Space) && alive) {

            rigibody_2d.linearVelocity = Vector2.up * birdparameter;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        logicmanager.gameover();
        alive = false;
    }
}
