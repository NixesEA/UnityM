using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 20f;

    void OnMouseDrag()
    {
        Vector3 mousePosition =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x < 0)
        {
            player.position = Vector2.MoveTowards(player.position, new Vector2(-300, player.position.y), speed * Time.deltaTime);
        }
        else
        {
            player.position = Vector2.MoveTowards(player.position, new Vector2(300, player.position.y), speed * Time.deltaTime);
        }
    }
}
