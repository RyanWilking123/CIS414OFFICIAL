
[CreateAssetMenu(fileName = "new Item", menuName = "Inventory")]



public class InventoryItem : ScriptableObject
{

    public string monsterName;
    public int health;
    public int power;


    public string Item()
    {
        return monsterName;
    }
    

   


}
