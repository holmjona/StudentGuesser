using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class ParticipantAnswer {
		private Question _Question;
		private Participant _Participant;
		private string _Answer;

		public Question Question {
			get { return _Question; }
			set { _Question = value; }
		}

		public Participant Participant {
			get { return _Participant; }
			set { _Participant = value; }
		}


		public string Answer {
			get { return _Answer; }
			set { _Answer = value; }
		}



	}
