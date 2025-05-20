public class Report
{
    public string _IncidentType {  get;private set; }
    public int _Zone {  get; private set; }

    private int _Serious;

    private string _Escription;

    public Report(string IncidentType , int Zone , int Serious, string Escription)
    {
        _IncidentType= IncidentType;
        _Zone= Zone;
        _Serious= Serious;
        _Escription= Escription;


    }

    
}
