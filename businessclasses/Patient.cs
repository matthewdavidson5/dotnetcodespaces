// See https://aka.ms/new-console-template for more information

namespace businessclasses 
{
    public class Patient 
    {

        private int intPatientID;
        private int intAccountID;
        private string strPatientFirstName; 
        private string strPatientMiddleName;
        private string strPatientLastName;
        private string strPatientStreet;
        private string strPatientCity;
        private string strPatientState; 
        private string strPatientZIP;
        private string strPatientPrimaryPhone;
        private string strPatientSecondaryPhone;
        private string strPatientSSN;
        private DateTime dtPatientDOB;
        private bool boolIsMinor; 
        private int intPatientHeadOfHouse;
        private string[] strarrPatientAllergies;
       
        public Patient(int intPatientID, int intAccountID, string strPatientFirstName, string strPatientMiddleName, string strPatientLastName, string strPatientStreet, string strPatientCity, string strPatientState, string strPatientZIP, string strPatientPrimaryPhone, string strPatientSecondaryPhone, string strPatientSSN, DateTime dtPatientDOB, bool boolIsMinor, int intPatientHeadOfHouse, string[] strarrPatientAllergies) 
        {
            this.intPatientID = intPatientID;
            this.intAccountID = intAccountID;
            this.strPatientFirstName = strPatientFirstName;
            this.strPatientMiddleName = strPatientMiddleName;
            this.strPatientLastName = strPatientLastName;
            this.strPatientStreet = strPatientStreet;
            this.strPatientCity = strPatientCity;
            this.strPatientState = strPatientState;
            this.strPatientZIP = strPatientZIP;
            this.strPatientPrimaryPhone = strPatientPrimaryPhone;
            this.strPatientSecondaryPhone = strPatientSecondaryPhone;
            this.strPatientSSN = strPatientSSN;
            this.dtPatientDOB = dtPatientDOB;
            this.boolIsMinor = boolIsMinor;
            this.intPatientHeadOfHouse = intPatientHeadOfHouse;
            this.strarrPatientAllergies = strarrPatientAllergies;
        }

        public int IntPatientID 
        {
            get 
            {
                return this.intPatientID;
            }
            set 
            {
                this.intPatientID = value; 
            }
        }

        public int IntAccountID
        {
            get 
            {
                return this.intAccountID;
            }
            set
            {
                this.intAccountID = value; 
            }
        }

        public string StrPatientFirstName
        {
            get
            {
                return this.strPatientFirstNam;
            }
            set
            {
                this.strPatientFirstName = value; 
            }
        }

        public string StrPatientMiddleName
        {
            get
            {
                return this.strPatientMiddleName;
            }
            set
            {
                this.strPatientMiddleName = value;
            }
        }

        public string StrPatientLastName
        {
            get
            {
                return this.strPatientLastName;
            }
            set
            {
                this.strPatientLastName = value; 
            }
        }

        public string StrPatientStreet
        {
            get
            {
                return this.strPatientStreet;
            }
            set
            {
                this.strPatientStreet = value;
            }
        }

        public string StrPatientCity
        {
            get
            {
                return this.strPatientCity;
            }
            set
            {
                this.strPatientCity = value;
            }
        }

        public string StrPatientState
        {
            get
            {
                return this.strPatientState;
            }
            set
            {
                this.strPatientState = value; 
            }
        }
        
        public string StrPatientZIP
        {
            get
            {
                return this.strPatientZIP;
            }
            set
            {
                this.strPatientZIP = value;
            }
        }

        public string StrPatientPrimaryPhone
        {
            get
            {
                return this.strPatientPrimaryPhone;
            }
            set
            {
                this.strPatientPrimaryPhone = value;
            }
        }

        public string StrPatientSecondaryPhone
        {
            get
            {
                return this.strPatientSecondaryPhone;
            }
            set
            {
                this.strPatientSecondaryPhone = value;
            }
        }

        public string StrPatientSSN
        {
            get
            {
                return this.strPatientSSN;
            }
            set
            {
                this.strPatientSSN = value;
            }
        }

        public DateTime DtPatientDOB
        {
            get
            {
                return this.dtPatientDOB;
            }
            set
            {
                this.dtPatientDOB = value;
            }
        }

        public bool BoolIsMinor
        {
            get
            {
                return this.boolIsMinor;
            }
            set
            {
                this.boolIsMinor = value;
            }
        }

        public int IntPatientHeadOfHouse
        {
            get
            {
                return this.intPatientHeadOfHouse;
            }
            set
            {
                this.intPatientHeadOfHouse = value;
            }
        }

        public string[] StrarrPatientAllergies
        {
            get
            {
                return this.strarrPatientAllergies;
            }
            set
            {
                this.strarrPatientAllergies = value;
            }
        }
    }
}
