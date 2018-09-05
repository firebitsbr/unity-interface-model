using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private ObjectHolder _objHolder;
    private InitialSceneSpawner _initSceneSpawn;
    private DestructionManager _destManager;
    private CollisionManager _collManager;
    private GameLogics _gameLogics;
    private MouseTracker _mouseTrack;
    private KeyBoardTracker _keyboardTrack;

    void Start()
    {
        InitAll();
        ManagersStart();
    }

    void InitAll()
    {
        _objHolder = new ObjectHolder();
        _destManager = new DestructionManager(_objHolder);
        _collManager = new CollisionManager(_objHolder);
        _initSceneSpawn = new InitialSceneSpawner(_objHolder, _collManager);
        _gameLogics = new GameLogics(_objHolder);
        _mouseTrack = new MouseTracker();
        _keyboardTrack = new KeyBoardTracker();
    }

    void ManagersStart()
    {
        _initSceneSpawn.OnStartManager();
        _destManager.OnStartManager();
        _collManager.OnStartManager();
        _gameLogics.OnStartManager();
    }

    void Update()
    {

    }
}
