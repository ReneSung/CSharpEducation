using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
  internal class Phonebook
  {
    private static Phonebook instance;
    private static string path = "phonebook.txt";
    public List<string> AbonentList { get; }
    public void PrintAbonentList()
    {
      

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="abonent"></param>
    public void AddAbonent(Abonent abonent)
    {
      string structString = $"{abonent.Name}: {abonent.PhoneNumber}";
      //AbonentList.Add(structString);
      WriteToFile(structString);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    static void WriteToFile(string str)
    {
      using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
      {
        sw.WriteLine(str);
      }
    }
    
    public static Phonebook getInstance()
    {
      if (instance == null)
        instance = new Phonebook();
      return instance;
    }
    private Phonebook()
    {
      using (StreamReader sr = new StreamReader(path))
      {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
          AbonentList.Add(line);
        }
      }
    }
  }
}
