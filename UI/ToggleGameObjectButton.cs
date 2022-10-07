using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Unity.FPS.UI
{
    public class ToggleGameObjectButton : MonoBehaviour
    {
        public GameObject GameObjectToToggle;
        public bool ResetSelectionAfterClick;

        void Update()
        {
            if (GameObjectToToggle.activeSelf && Input.GetButtonDown(GameConstants.k_ButtonNameCancel))
            {
                SetGameObjectActive(false);
            }
        }

        public void SetGameObjectActive(bool active)
        {
            GameObjectToToggle.SetActive(active);

            if (ResetSelectionAfterClick)
                EventSystem.current.SetSelectedGameObject(null);
        }
    }
}