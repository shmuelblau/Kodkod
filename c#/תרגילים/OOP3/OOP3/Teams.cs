public class FloodsTeam : Team
{
    public FloodsTeam(string Name, int Zone, bool Available) : base(Name, Zone, Available)
    {

    }

    public override bool canHelp(Report r)
    {
        return r._Zone == _Zone && r._IncidentType == "Floods" && _Available;
    }

    public override string handling() { return "Floods team took care of the problem!!"; }
    
}



public class InjuriesTeam : Team
{
    public InjuriesTeam(string Name, int Zone, bool Available) : base(Name, Zone, Available)
    {

    }

    public override bool canHelp(Report r)
    {
        return r._Zone == _Zone && r._IncidentType == "Injuries" && _Available;
    }
    public override string handling() { return "Injuries team took care of the problem!!"; }
}




public class BlockagesTeam : Team
{
    public BlockagesTeam(string Name, int Zone, bool Available) : base(Name, Zone, Available)
    {

    }

    public override bool canHelp(Report r)
    {
        return r._Zone == _Zone && r._IncidentType == "Blockages" && _Available ;
    }
    public override string handling() { return "Blockages team took care of the problem!!"; }

}