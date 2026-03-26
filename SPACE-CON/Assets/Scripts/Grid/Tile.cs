using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private bool _debugMode;
    [SerializeField] GameObject TestRoom;
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
    private void OnMouseUp()
    {
        if (BuildPhaseManager.instance.HeldItem != null)
        {
            BuildPhaseManager.instance.HeldItem.gameObject.transform.position = transform.position;
        }
    }
}
