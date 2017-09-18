using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFairs
{
  public class People
  {
    private int _ID;
    private string _First;
    private string _MI;
    private string _Last;
    private string _Title;
    private string _Address1;
    private string _Address2;
    private string _City;
    private string _State;
    private string _Zip;
    private string _EMail;
    private string _Phone;

    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }


    public string First
    {
      get { return _First; }
      set { _First = value; }
    }

    public string MI
    {
      get { return _MI; }
      set { _MI = value; }
    }

    public string Last
    {
      get { return _Last; }
      set { _Last = value; }
    }

    public string Title
    {
      get { return _Title; }
      set { _Title = value; }
    }

    public string Address1
    {
      get { return _Address1; }
      set { _Address1 = value; }
    }

    public string Address2
    {
      get { return _Address2; }
      set { _Address2 = value; }
    }

    public string City
    {
      get { return _City; }
      set { _City = value; }
    }

    public string State
    {
      get { return _State; }
      set { _State = value; }
    }

    public string Zip
    {
      get { return _Zip; }
      set { _Zip = value; }
    }

    public string EMail
    {
      get { return _EMail; }
      set { _EMail = value; }
    }

    public string Phone
    {
      get { return _Phone; }
      set { _Phone = value; }
    }
  }
}
