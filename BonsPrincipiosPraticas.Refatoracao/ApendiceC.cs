using System.Collections.Generic;

namespace BonsPrincipiosPraticas.Refatoracao
{
    public class Process
    {
    }

    public class Field
    {
    }

    public class Warning
    {
    }

    public class Checklist
    {
    }

    public class JsonPatchDocument<T>
    {
    }

    public interface IProcessServiceCommands
    {   
        Process AddChecklist(Checklist checklist, string id);
        Process AddCustomField(Field field, string id);
        Process AddWarning(Warning warning, string id);
        Process Create(Process process);
        Process Delete(int publicId);
        Process Patch(JsonPatchDocument<Process> patchItem, int publicId, string id);
        Process Update(Process process);
    }

    public interface IProcessServiceQueries
    {
        Process DiscoveryChecklist(Process process);
        Process Find(string id);
        Process Find(int publicId);
        Process Find(int publicId, int version);
        List<Process> FindByMecId(int mecPublicId);
        List<Process> FindProcessesFromList(string[] ids);
        List<Process> FindProcessesFromPublicIds(string @params);
        List<Process> FindProcessesFromPublicIds(List<int> publicIds);        
        List<Process> List();        
    }
}
