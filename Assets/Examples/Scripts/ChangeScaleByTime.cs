using UnityEngine;

namespace Example.UnityModule.TransformConstraint
{
    public class ChangeScaleByTime : MonoBehaviour
    {
        private Vector3 OriginalScale;

        void Start()
        {
            this.OriginalScale = this.transform.localScale;
        }

        void Update()
        {
            var time = (Time.frameCount % 60) / 60f;
            var value = Mathf.Sin(2 * Mathf.PI * time);
            this.transform.localScale = this.OriginalScale + (Vector3.one * value);
        }
    }
}