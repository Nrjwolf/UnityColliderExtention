using System;
using UnityEngine;

public class ColliderListener : MonoBehaviour
{
    public Action<Collision2D> onCollisionEnter2D;
    public Action<Collision2D> onCollisionStay2D;
    public Action<Collision2D> onCollisionExit2D;

    public Action<Collider2D> onTriggerEnter2D;
    public Action<Collider2D> onTriggerStay2D;
    public Action<Collider2D> onTriggerExit2D;

    //--- Collision2D ---//

    public void OnCollisionEnter2D(Collision2D collision)
    {
        onCollisionEnter2D(collision);
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        onCollisionStay2D(collision);
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        onCollisionExit2D(collision);
    }

    //--- Trigger2D ---//

    public void OnTriggerEnter2D(Collider2D collider)
    {
        onTriggerEnter2D(collider);
    }

    public void OnTriggerStay2D(Collider2D collider)
    {
        onTriggerEnter2D(collider);
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        onTriggerExit2D(collider);
    }
}
