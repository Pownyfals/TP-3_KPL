using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204081
{
	internal class DoorMachine
	{
		//deklarasi
		enum State { terkunci, terbuka};
		private State state = State.terkunci;
		
		public DoorMachine()
		{
			state = State.terkunci;
		}

		public string getState()
		{
			if (state == State.terkunci)
			{
				return "Pintu Terkunci";
			}
			return "Pintu Tidak Terkunci";
		}
		public void bukaPintu()
		{
			switch (state)
			{
				case State.terkunci:
					state = State.terbuka;
				break;

				case State.terbuka:
					state = State.terbuka;
				break;

			}
		}
		public void tutupPintu()
		{
			switch (state)
			{
				case State.terkunci:
					state = State.terkunci;
				break;

				case State.terbuka:
					state = State.terkunci;
				break;
			}
		}
	}
}
