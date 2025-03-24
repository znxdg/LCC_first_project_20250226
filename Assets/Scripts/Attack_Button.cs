using UnityEngine;

namespace YuCheng
{

    public class Attack_Button : MonoBehaviour
    {
        public void click()
        {
            Player user = Object.FindFirstObjectByType<Player>();
            Enemy enemy = Object.FindFirstObjectByType<Enemy>();
            Debug.Log("click() 方法被呼叫！");

            user.Attack(enemy, 5, Player.StatType.Intelligence);
        }
    }
}
