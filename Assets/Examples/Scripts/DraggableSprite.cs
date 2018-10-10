using UnityEngine;

namespace Example.UnityModule.TransformConstraint
{
    public class DraggableSprite : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                this.transform.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
}