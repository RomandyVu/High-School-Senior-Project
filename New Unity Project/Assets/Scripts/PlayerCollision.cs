using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerPlatformerController movement;

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag ==  "DefeatCondition")

        FindObjectOfType<GameDectector>().EndGame();

        Debug.Log("You serious?");
    }

   

}
