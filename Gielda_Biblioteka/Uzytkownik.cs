using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public class Uzytkownik
    {
        private int _id;
        private string _firstName;
        private string _lasName;

        public Uzytkownik() { }
        public Uzytkownik(int id, string firstName, string lasName)
        {
            _firstName = firstName;
            _lasName = lasName;
            _id = id;
        }

        public string LastName
        {
            get { return _lasName; }
            set { _lasName = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public override string ToString()
        {
            return $"Id: {_id}; Imie: {_firstName}; Nazwisko: {_lasName}; \n";
        }
    }
}
