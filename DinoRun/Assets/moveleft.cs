using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    public float speed = 1f; //움직이는 속도 지정
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
