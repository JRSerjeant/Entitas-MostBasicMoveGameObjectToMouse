using Entitas;
using UnityEngine;

public class SystemLoad : MonoBehaviour {

    Systems _systems;

    // Use this for initialization
    void Start () {
        var pools = Pools.sharedInstance;
        pools.SetAllPools();
        _systems = createSystems(pools.core);
        _systems.Initialize();
    }
	
	// Update is called once per frame
	void Update () {
        _systems.Execute();
    }

    Systems createSystems(Pool pool)
    {

        return new Feature("Systems")
            .Add(pool.CreateSystem(new CreateEntitySystem()))
            .Add(pool.CreateSystem(new InstantiateGameObjectSystem()))
            .Add(pool.CreateSystem(new MoveToMouseSystem()))
            //.Add(pool.CreateSystem(new RemoveGameObjectSystem()))
            ;
    }
}
