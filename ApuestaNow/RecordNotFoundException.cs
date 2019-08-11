using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RecordNotFoundException : Exception
{
    private string _message;
    public string Message
    {
        get { return _message; }
    }
    public RecordNotFoundException()
    {
        _message = "Record not found";
    }
    public RecordNotFoundException(object id)
    {
        _message = "Record not found for id " + id.ToString();
    }
}
