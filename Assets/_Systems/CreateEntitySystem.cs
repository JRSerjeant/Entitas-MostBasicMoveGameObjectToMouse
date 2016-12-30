using System;
using Entitas;

class CreateEntitySystem : IInitializeSystem, ISetPool
{

    Pool _pool;

    public void Initialize()
    {
        _pool.CreateEntity().AddPrefabName("MyTestCube").IsMoveToMouse(true).AddSpeed(1.0f);
    }

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }
}

