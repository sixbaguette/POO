public class Item
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string description;
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    private float weight;
    public float Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    private int value;
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
    public Item(string name, string description, float weight, int value)
    {
        this.name = name;
        this.description = description;
        this.weight = weight;
        this.value = value;
    }
}