using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    Vector3 pos;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        pos = Input.mousePosition;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);

        Vector2 direction = new Vector2
            ( pos.x - transform.position.x * 4,
              pos.y - transform.position.y * 4);

        transform.up = direction;



    }
  
}
