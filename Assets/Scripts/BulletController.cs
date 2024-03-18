using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletController : MonoBehaviour
{
    private Vector3 bulletPosition;
    // Start is called before the first frame update
    void Start()
    {
        bulletPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        bulletPosition = transform.position;
        if (bulletPosition.y < -1 || bulletPosition.y > 10 || bulletPosition.x < -10 || bulletPosition.x > 10 || bulletPosition.z < -10 || bulletPosition.z > 10){
            Destroy(gameObject);
        }
    }
}
