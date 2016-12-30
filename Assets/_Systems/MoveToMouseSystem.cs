using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class MoveToMouseSystem : IExecuteSystem, ISetPools
{

    Pools _pools;
    Group _MoveToMouse;
    Vector2 target = new Vector2(0, 0);

    public void Execute()
    {
        if(Input.GetMouseButtonDown(0))
        {
            target = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            target = Camera.main.ScreenToWorldPoint(target);
        }

        _MoveToMouse = _pools.core.GetGroup(CoreMatcher.MoveToMouse);
            
        foreach (var item in _MoveToMouse.GetEntities())
        {
            item.gameObject.gameObject.transform.position = Vector2.MoveTowards(item.gameObject.gameObject.transform.position, target, item.speed.speed);
        }
    }

    public void SetPools(Pools pools)
    {
        _pools = pools;
        _MoveToMouse = pools.core.GetGroup(CoreMatcher.MoveToMouse); 
    }
}
