using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameDectector It;
    private void OnTriggerEnter2D ()
    {
        FindObjectOfType<GameDectector>().CompleteLevel();
    }
}
