using UnityEngine;

public class Room : MonoBehaviour
{
    public string Name;
    public bool OnMenu;
    public GameObject Prefab;
    public Room(string name)
    {
        Name = name;
    }
    public void OnClick()
    {
        Debug.Log("clicka");
        if (OnMenu)
        {
            BuildPhaseManager.instance.HeldItem = Instantiate(Prefab, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        }
        else
        {
            BuildPhaseManager.instance.HeldItem = gameObject;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("clicka");
        if (OnMenu)
        {
            BuildPhaseManager.instance.HeldItem = Instantiate(Prefab, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        }
        else
        {
            BuildPhaseManager.instance.HeldItem = gameObject;
        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
