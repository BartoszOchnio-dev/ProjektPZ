using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gielda_Biblioteka
{
    public class Gielda
    {
		private List<InstrumentInfo> _instruments;
		private List<Uzytkownik> _users;


		public Gielda() {
			_instruments = new List<InstrumentInfo>();
			_users = new List<Uzytkownik>();
		}
		public Gielda(List<InstrumentInfo> instruments, List<Uzytkownik> users)
		{
			_instruments = instruments;
			_users = users;
		}

        public List<Uzytkownik> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public List<InstrumentInfo> Instyments
		{
			get { return _instruments; }
			set { _instruments = value; }
		}

		public void addInstrument(InstrumentInfo instrumentInfo)
		{
			_instruments.Add(instrumentInfo);
		}

		public void addUser(Uzytkownik user)
		{
			_users.Add(user);
		}

		public void showAllInstruments()
		{
			foreach (InstrumentInfo instrumentInfo in _instruments)
			{
				Console.WriteLine(instrumentInfo.ToString());
			}
		}
		public void showAllUsers()
		{
			foreach(Uzytkownik user in _users) { 
				Console.WriteLine(user.ToString()); 
			}
		}

		public InstrumentInfo findByInstrument(InstrumentFinansowy instrument)
		{
			foreach(InstrumentInfo info in _instruments)
			{
				if(info.Instrument == instrument)
				{
					return info;
				}
			}
			return null;
		}



    }
}
