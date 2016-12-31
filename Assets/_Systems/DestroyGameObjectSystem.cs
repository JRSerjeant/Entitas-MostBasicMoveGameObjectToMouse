using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class DestroyGameObjectSystem : IReactiveSystem, ISetPool
{
    Pool _pool;

    public TriggerOnEvent trigger
    {
        get
        {
            return CoreMatcher.Destroy.OnEntityAdded();
        }
    }

    public void Execute(List<Entity> entities)
    {
        foreach (var e in entities)
        {
            GameObject.Destroy(e.gameObject.gameObject);
            _pool.DestroyEntity(e);
        }
    }

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }
}
