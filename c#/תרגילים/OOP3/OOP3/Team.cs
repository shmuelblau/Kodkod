public class Team
{
    public string _Name { get; private set; }
    public int _Zone { get; private set; }

    public bool _Available { get; set; }


    public Team(string Name, int Zone, bool Available)
    {
        _Name = Name;
        _Zone = Zone;
        
        _Available = Available;


    }

    public virtual bool canHelp(Report r) {  return false; }
    public virtual string handling() {  return "cent help"; }


}
