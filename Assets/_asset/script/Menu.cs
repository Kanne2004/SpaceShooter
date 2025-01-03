using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace demo2d
{
    public class Menu : MonoBehaviour
    {
        public void OnPlayButtonClicked()
        {
            SceneManager.LoadScene("Battle");
        }

    }
}

