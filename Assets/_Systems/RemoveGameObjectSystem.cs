using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class RemoveGameObjectSystem : IInitializeSystem /*: IReactiveSystem, ISetPool*/
{
    Entity _Entity;
    Pool _Pool;


    //public void Init(Pool pool, Entity entity)
    //{
    //    _Entity = entity;
    //    _Entity.OnEntityReleased += OnEntityReleased;
    //}

    public void Initialize()
    {
        _Entity.OnEntityReleased += OnEntityReleased;
    }

    //Pool _pool;

    //public TriggerOnEvent trigger
    //{
    //    get
    //    {
    //        return Entity;
    //    }
    //}

    //public void Execute(List<Entity> entities)
    //{
    //    foreach (var e in entities)
    //    {
    //        //UnityEngine.Object.Destroy(e.gameObject.gameObject);
    //        //e.gameObject.gameObject;
    //    }
    //}

    void OnEntityReleased(Entity entity)
    {
        Debug.Log("onEntityRemoved");
        Debug.Log(entity.gameObject);
        Debug.Log(entity.gameObject.gameObject);
        UnityEditor.EditorApplication.isPaused = true;

        GameObject.Destroy(entity.gameObject.gameObject);
    }

    //public void SetPool(Pool pool)
    //{
    //    pool.GetGroup(CoreMatcher.GameObject).OnEntityRemoved += onEntityRemoved;
    //}
}
