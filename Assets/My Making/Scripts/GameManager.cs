using UnityEngine;

public class GameManager : MonoBehaviour
{
    private SpawningBoxes spawner;

    private bool leftHeld;
    private bool rightHeld;
    private bool gameStarted;


    private void Awake()
    {
        spawner = GetComponent<SpawningBoxes>();
    }

    public void Update()
    {
        if (gameStarted)
        {
            if (!leftHeld || !rightHeld)
            {
                TryStopGame();
            }
        }
    }
    public void SaberPickedUp(bool isLeft)
    {
        if (isLeft) leftHeld = true;
        else rightHeld = true;

        TryStartGame();
    }

    public void SaberReleased(bool isLeft)
    {
        if (isLeft) leftHeld = false;
        else rightHeld = false;
    }

    private void TryStartGame()
    {
        if (gameStarted) return;

        if (leftHeld && rightHeld)
        {
            gameStarted = true;
            spawner.StartSpawning();
            Debug.Log("Game started (both sabers grabbed)");
        }
    }

    private void TryStopGame()
    {
        spawner.StopSpawning();
        gameStarted = false;
        Debug.Log("Game Stopped / Saber was dropped");
    }

}
