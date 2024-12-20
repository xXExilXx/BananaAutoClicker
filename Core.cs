using MelonLoader;
using Il2CppClicker;
using UnityEngine.UIElements;
using UnityEngine;

[assembly: MelonInfo(typeof(BananaAutoClicker.Core), "BananaAutoClicker", "1.0.5", "Exil_S", null)]
[assembly: MelonGame("OnlyBananasStudio", "Banana")]

namespace BananaAutoClicker
{
    public class Core : MelonMod
    {
        private GameManager gameManager;
        private bool active;
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized Auto Clicker.");
        }

        public override void OnLateInitializeMelon()
        {
            gameManager = UnityEngine.MonoBehaviour.FindObjectOfType<GameManager>();
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                active = !active;
                LoggerInstance.Msg(active ? "Auto Clicker Active" : "Auto Clicker Paused");
            }
            
            if(gameManager != null && active)
                gameManager.AddBanana();
        }
    }
}