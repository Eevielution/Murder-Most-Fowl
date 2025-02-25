using UnityEngine;

[RequireComponent(typeof(SceneManager), typeof(StateManager))]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private SceneManager m_sceneManager;
    public static SceneManager SceneManager => Instance.m_sceneManager;

    private StateManager m_stateManager;
    public static StateManager StateManager => Instance.m_stateManager;
    public static State State => StateManager.ActiveState;


    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        else Instance = this;

        m_sceneManager = GetComponent<SceneManager>();
        m_stateManager = GetComponent<StateManager>();
    }
}