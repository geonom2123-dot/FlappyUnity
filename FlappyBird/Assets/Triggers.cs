using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Triggers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public LogicManager logicmanager;
    void Start()
    {
        logicmanager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicmanager.addScore();
        }

    }
}
