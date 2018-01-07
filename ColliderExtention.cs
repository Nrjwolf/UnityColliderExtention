using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColliderExtention
{

    //--- Collision2D ---//

    public static void OnCollisionEnter2D(this Collision2D collision, Action<Collision2D> callback)
    {
        CheckColliderListenerComponent(collision.collider).onCollisionEnter2D += callback;
    }

    public static void OnCollisionStay2D(this Collision2D collision, Action<Collision2D> callback)
    {
        CheckColliderListenerComponent(collision.collider).onCollisionStay2D += callback;
    }

    public static void OnCollisionExit2D(this Collision2D collision, Action<Collision2D> callback)
    {
        CheckColliderListenerComponent(collision.collider).onCollisionExit2D += callback;
    }

    //--- Trigger2D ---//

    public static void OnTriggerStay2D(this Collider2D collider, Action<Collider2D> callback)
    {
        CheckColliderListenerComponent(collider).onTriggerStay2D += callback;
    }

    public static void OnTriggerEnter2D(this Collider2D collider, Action<Collider2D> callback)
    {
        CheckColliderListenerComponent(collider).onTriggerEnter2D += callback;
    }

    public static void OnTriggerExit2D(this Collider2D collider, Action<Collider2D> callback)
    {
        CheckColliderListenerComponent(collider).onTriggerExit2D += callback;
    }

    /// Добавляет ColliderListener, если его нет
    private static ColliderListener CheckColliderListenerComponent(Collider2D collider)
    {
        if (collider.GetComponent<ColliderListener>() == null)
            return collider.gameObject.AddComponent<ColliderListener>();
        return collider.gameObject.GetComponent<ColliderListener>();
    }
}
