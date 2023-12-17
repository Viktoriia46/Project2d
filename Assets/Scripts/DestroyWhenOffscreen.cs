using UnityEngine;

public class DestroyWhenOffscreen : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}