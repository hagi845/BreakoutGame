using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _oldX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _oldX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        }
        else if (Input.GetMouseButton(0))
        {
           var newX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            transform.Translate(newX - _oldX, 0, 0);
            _oldX = newX;
        }
    }
}
