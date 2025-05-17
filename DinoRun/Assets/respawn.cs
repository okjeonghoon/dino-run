using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //오브젝트가 특정위치에 도달했을때 스폰위치로 되돌린다

        if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }
    }
}
