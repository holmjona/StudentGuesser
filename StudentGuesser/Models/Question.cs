using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Question {
		public enum Types {
			MultipleChoice,
			ShortAnswer
		}

		private string	_Text;
		private Types _Type;
		private int _SecondsAllowed = 0;

		public string Text {
			get { return _Text; }
			set { _Text = value; }
		}

		public Types Type {
			get { return _Type; }
			set { _Type = value; }
		}

		public int SecondsAllowed {
			get { return _SecondsAllowed; }
			set { _SecondsAllowed = value; }
		}

	}
