public class Arme : ItemRamassable, IDamager
{
    private int id { get; set; }
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private int degat { get; set; }
    public int Degat
    {
        get { return degat; }
        set { degat = value; }
    }
    private int range { get; set; }
    public int Range
    {
        get { return range; }
        set { range = value; }
    }

    public Arme(int id, int degat, int range)
    {
        this.id = id;
        this.degat = degat;
        this.range = range;
    }

    public override void seFaireRamasser(IRamasser ramasseur)
    {
        base.seFaireRamasser(ramasseur);
        ramasseur.equiper(this);
    }

    public virtual void attaquer()
    {

    }

    public void faireDegats(IDamageable cible)
    {

    }
}