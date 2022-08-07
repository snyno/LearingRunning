using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperCat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector2.right * speed); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(-Vector2.right * speed); }
        if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(Vector2.up * speed); }

    }

}
