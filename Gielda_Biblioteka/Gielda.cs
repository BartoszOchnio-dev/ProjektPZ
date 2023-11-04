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
		private List<Interface1> _interface1s = new List<Interface1>();
		private List<Interface2> _interface2s = new List<Interface2>();

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

		public void copyToInteface()
		{
			_interface1s = new List<Interface1>();
			_interface2s = new List<Interface2>();
            foreach (InstrumentInfo info in _instruments)
            {
                if (info is Interface1)
                {
                    _interface1s.Add((Interface1)info);
                }
                if (info is Interface2)
                {
                    _interface2s.Add((Interface2)info);
                }
            }
        }
		public InstrumentInfoLimitowanyDostep findLimitedInsrumentByInstrument(InstrumentFinansowy instrument)
		{
			foreach(InstrumentInfoLimitowanyDostep inst in _interface1s)
			{
				if(inst.Instrument == instrument)
				{
					return inst;
				}
			}
			return null;
		}

        public InstrumentInfoNieLimitowanyDostep findNoLimitedInsrumentByInstrument(InstrumentFinansowy instrument)
        {
            foreach (InstrumentInfoNieLimitowanyDostep inst in _interface2s)
            {
                if (inst.Instrument == instrument)
                {
                    return inst;
                }
            }
            return null;
        }



    }
}
