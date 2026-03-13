using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private bool _debugMode;
    private void OnMouseEnter()
    {
        if (_debugMode)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
    private void OnMouseExit()
    {
        if (_debugMode)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
