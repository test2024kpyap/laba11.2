using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР11._2
{
    internal class ResearchTeam
    {
        string name;
        string organization;
        public TimeFrame TimeFrame {  get; set; }
        int registrationNumber;
        Paper[] publications;

        public string Name
        {
            get { return name; }
            set
            {
                if (value !=  null && value.Length >= 2) 
                {
                    name = value;
                }else
                {
                    name = "error";
                }
            }
        }

        public string Organization
        {
            get { return organization; }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    organization = value;
                }
                else
                {
                    organization = "error";
                }
            }
        }


        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set
            {
                if(value < 0)
                {
                    registrationNumber = 0;
                }
                else
                {
                    registrationNumber = value;
                }
            }
        }

        public Paper[] Publications
        {
            get { 
                if( publications == null)
                {
                    return null;
                }
                else
                {
                    Paper[] temp = { FindOldestPaper() };
                    return temp;
                }
            }
        }

        private Paper FindOldestPaper()
        {
            Paper max = publications[0];
            for (int i = 0; i < publications.Length; i++)
            {
                if(max.DatePublication < publications[i].DatePublication)
                {
                    max = publications[i];
                }
            }
            return max;
        }

        public ResearchTeam() { }
        public ResearchTeam(string name, string organization, TimeFrame timeFrame, int registrationNumber, Paper[] publications)
        {
            Name = name;
            Organization = organization;
            TimeFrame = timeFrame;
            RegistrationNumber = registrationNumber;
            this.publications = publications;
        }

        public override string ToString()
        {
            string a = "";
            foreach (Paper b in publications)
                a += b + "\n";
            return $"Name: {Name}, Organization: {Organization}, Timeframe:{TimeFrame}, RegistrationNumber:{RegistrationNumber}, Publications{a}";
        }

        public virtual string ToShortString()
        {
            return $"Name: {Name}, Organization: {Organization}, Timeframe:{TimeFrame}, RegistrationNumber:{RegistrationNumber}";
        }

        public bool this[TimeFrame duration]
        {
            get { return TimeFrame == duration; }
        }
        public void AddPapers(Paper[] arr)
        {
            int pubSize = 0;
            if(publications != null)
            {
                pubSize = publications.Length;
            }
            Paper[] papers = new Paper[pubSize+arr.Length];
            for(int i=0;i<pubSize;i++)
            {
                papers[i] = publications[i];
            } 
            for(int i=pubSize,j=0 ;i<arr.Length;i++,j++)
            {
                
                papers[i] = arr[j];
            }
            publications = papers;
        }
    }
}
