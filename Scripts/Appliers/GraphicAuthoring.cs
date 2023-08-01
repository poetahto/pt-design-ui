using DefaultNamespace;
using UnityEngine;

namespace Poetools.UI
{
    /// <summary>
    /// SO wrapper for a graphic's color..
    /// This is so you don't have to copy-paste settings around by hand, used in conjunction with <see cref="GraphicApplier"/>
    /// </summary>
    [CreateAssetMenu(menuName = DesignUINaming.AssetMenuName + "/Graphic Authoring")]
    public class GraphicAuthoring : ScriptableObject
    {
        [SerializeField]
        private Color color;

        public Color Color => color;
    }
}
