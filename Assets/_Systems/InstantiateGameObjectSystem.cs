using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class InstantiateGameObjectSystem : IReactiveSystem, ISetPool
{
    Pool _pool;

    public TriggerOnEvent trigger
    {
        get
        {
            return CoreMatcher.PrefabName.OnEntityAdded();
        }
    }

    public void Execute(List<Entity> entities)
    {
        foreach (var e in entities)
        {
            GameObject go = UnityEngine.GameObject.Instantiate<GameObject>(Resources.Load(e.prefabName.Name) as GameObject);
            e.AddGameObject(go);
        }
    }

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }
}
