using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public ObjectPool pool;

    public void Release()
    {
        pool.ReturnToPool(this);
	}
}
