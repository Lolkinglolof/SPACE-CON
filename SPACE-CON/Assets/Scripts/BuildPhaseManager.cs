using UnityEngine;

public class BuildPhaseManager : MonoBehaviour
{
    public static BuildPhaseManager instance;
    public GameObject HeldItem = null;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HeldItem != null)
        {
            Vector3 v = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            v.z = 0;
            HeldItem.transform.position = v;
        }
    }
    private void OnMouseUp()
    {
        /*
        if (HeldItem != null)
        {
            Invoke(nameof(RemoveHeldItem), 0.1f);
        }
        */
    }
    private void RemoveHeldItem()
    {
        HeldItem = null;
    }
}
