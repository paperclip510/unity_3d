using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) 주체 또는 대상에게 RigiBody 있어야 한다. (IsKinematic : Off)
    // 2) 주체에 Collider가 있어야 한다 (IsTrigger : Off)
    // 3) 대상에게 Collider가 있어야 한다 (IsTrigger : Off)
    void OnCollisionEnter(Collision collision)
    {
         Debug.Log($"OnCollisionEnter.. @ {collision.gameObject.name}");
    }


    // 1) 둘 다 Collider가 있어야 한다.
    // 2) 둘 중 하나는 IsTrigger : On
    // 3) 둘 중 하나는 RigidBody가 있어야 한다.
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter.. @ {other.gameObject.name}");
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
