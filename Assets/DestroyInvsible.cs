using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvsible:MonoBehaviour
{
    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}