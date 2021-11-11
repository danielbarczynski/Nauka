using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace WzorzecAdapter
{
    //KOD Z ZEWNĘTRZNEJ BIBLIOTEKI
    public class UsersApi
    {
        public async Task<string> GetUsersXmlAsync()
        {
            var apiResponse = "<?xml version= \"1.0\" encoding= \"UTF-8\"?><users><user name=\"John\" surname=\"Doe\"/>" +
            "<user name=\"John\" surname=\"Wayne\"/><user name=\"John\" surname=\"Rambo\"/></users>";

            XmlDocument doc = new ();
            doc.LoadXml(apiResponse);

            return await Task.FromResult(doc.InnerXml);
        }
    }

    public interface IUserRepository
    {
        List<string> GetUserNames();
    }

    public class UsersRepositoryAdapter : IUserRepository
    {
        private UsersApi _adaptee = null;

        public UsersRepositoryAdapter(UsersApi adaptee)
        {
            _adaptee = adaptee;
        }

        public List<string> GetUserNames()
        {
            string incompatibleApiResponse = this._adaptee.GetUsersXmlAsync().GetAwaiter().GetResult();

            XmlDocument doc = new ();
            doc.LoadXml(incompatibleApiResponse);

            var rootEl = doc.LastChild;

            List<string> userNames = new ();

            if (rootEl.HasChildNodes)
            {
                foreach (XmlNode user in rootEl.ChildNodes)
                {
                    userNames.Add(user.Attributes["name"].InnerText + user.Attributes["surname"].InnerText);
                }
            }
            return userNames;
        }
    }


    public class Program
    {

        static void Main(string[] args)
        {
            UsersApi userRepository = new ();

            IUserRepository adapter = new UsersRepositoryAdapter(userRepository);

            List<string> users = adapter.GetUserNames();
            foreach (var userName in users)
            {
                Console.WriteLine(userName);
            }

           // var csvData = "kolumna1,kolumna2,kolumna3";
        }

    }


}