using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderCat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) { transform.Translate(Vector2.right * speed); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(-Vector2.right * speed); }
        if (Input.GetKey(KeyCode.W)) { transform.Translate(Vector2.up * speed); }
    }
}
