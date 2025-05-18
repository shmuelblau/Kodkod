using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

public class Agent
{
    private int ClearanceLevel;
    public string CodeName { get; set; }

    public int GetClearanceLevel() { return ClearanceLevel; }
    public void setClearanceLevel(int num) 
    { 
        if (num > 0 && num < 6 )
            ClearanceLevel = num;
    }

    public void Report()
    {
        Console.WriteLine($"Agent {CodeName} reporting. Clearance Level: {ClearanceLevel}");
        
    }

}



public class Mission
{
    public string MissionName { get; set; }
    public string TargetLocation { get; set; }

    public Agent AssignedAgent { get; set; }

    public void Brief()
    {
        Console.WriteLine($"Mission: {MissionName}, Target: {TargetLocation},\r\nAgent: {AssignedAgent.CodeName}");
    }



    

}

public static class IntelTools
{
   public static string EncryptMessage(string msg)
    {
        return msg.Reverse().ToString();
    }

    public static void ogTransmission(string agentName, string message)
    {
        Console.WriteLine($"{agentName} sent\r\nencrypted message: {message}");
    }

}