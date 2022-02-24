using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    /**Variables**/

    #region GameManager Singleton
    static private GameManager gm; //Reference to the Game Manager
    static public GameManager GM { get { return gm; } } //public Access to Game Manager

    [Header("General Settings")]
    public string gameTitle = "HoG";
    public string gameCredits = "N/A";

    [Header("Game Settings")]
    [Tooltip("Can the level be beat by a score?")]
    public bool canBeatLevel = false; //Does a score make it beat?
    public int scoreToBeat = 1000;

    [Space(10)]
    [Tooltip("Is the level timed?")]
    public bool timedLevel = false;
    public float startTime = 5.0f;//Time for level

    [SerializeField] //access to private booleans
    [Tooltip("Testlives!")]
    private int lives = 1;

    public int Lives { get { return lives; } set { lives = value; } }

    [SerializeField] //access to private booleans
    [Tooltip("Test dieing!")]
    private bool died = false;

    public bool Died { get { return died; } set { died = value; } }

    [Header("Scene Settings")]
    [Tooltip("Is the level timed?")]
    public string startScene;
    public string endScene;
    public string gameOverScene;

    public static int currentScene;

    public string[] gameLevels;

    [HideInInspector] public enum gameStates { Idle, Playing, Death, GameOver, BeatLevel}
    [HideInInspector] public gameStates gameState = gameStates.Idle;

    private float currentTime;
    void CheckGameManagerIsInScene()
    {
        if (gm == null)
        {
            gm = this;
            Debug.Log(gm);
        }
        else
        {
            Destroy(this.gameObject); //Destroys duplicate game managers
        }

        DontDestroyOnLoad(this); //Keeps this Open!!
    }
    #endregion

    private void Awake()
    {
        CheckGameManagerIsInScene();

        currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
    }

    // Start is called before the first frame update
    void StartGame()
    {
        SceneManager.LoadScene(gameLevels[0]);

        gameState = gameStates.Playing;
        //lives = numberOfLives;
        //score = 0;
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Exited");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape")) { ExitGame(); }

        if(gameState == gameStates.Playing)
        {
            if(Died && Lives == 0) { }
        }
    }

    void GameOver()
    {
        gameState = gameStates.GameOver;
        SceneManager.LoadScene(gameOverScene);
    }
}
