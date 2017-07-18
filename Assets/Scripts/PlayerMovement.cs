using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Transform tail;

    [SerializeField]
    float moveScale;

    float speedX = 1;
    float speedY = 0;

    GameObject[] tails;
    Transform _transform;

    void Start()
    {
        _transform = this.transform;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if(moveHorizontal > 0)
        {
            speedX = 1;
            speedY = 0;
        } else if (moveHorizontal < 0)
        {
            speedX = -1;
            speedY = 0;
        }

        _transform.Translate(new Vector3(speedX * moveScale * Time.deltaTime, 0.0f, 0.0f));

        float moveVertical = Input.GetAxis("Vertical");
        _transform.Translate(new Vector3(0.0f, moveVertical * Time.deltaTime, 0.0f));
    }
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
    }
}
