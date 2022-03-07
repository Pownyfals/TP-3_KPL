using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204081
{
	internal class KodePos
	{
		private string kelurahan;
		private int kodePos;

		//constructor
		public KodePos(string k, int kP)
		{
			this.kelurahan = k;
			this.kodePos = kP;
		}

		public int getKodePos()
		{
			return kodePos;
		}

	}
}
